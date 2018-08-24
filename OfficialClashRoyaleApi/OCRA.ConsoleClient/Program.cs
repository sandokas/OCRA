using OCRA.Repositories.Official;
using OCRA.Repositories.Official.Contracts.DTO;
using OCRA.Repositories.Official.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OCRA.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CultureInfo culture = new CultureInfo("pt-PT");
            Console.OutputEncoding = Encoding.UTF8;
            string clan = "#8YQ9828";

            IClanRepository clanRepository = new ClanRepository();
            IList<Member> members = clanRepository.GetClanMembersByTag(clan);
            foreach (Member member in members)
            {
                Console.WriteLine($"Nome do membro {member.Name} que tem {member.Trophies} e está na arena {member.Arena?.Name.ToString(culture)}. Tem o cargo de {member.Role.ToString()}.");
            }

            War war = clanRepository.GetCurrentWarByTag(clan);
            
            if (war.State.Equals("warDay"))
            {
                Console.WriteLine($"Current clan {war.Clan.Name} war status is {war.State}");
                foreach (Participant participant in war.Participants)
                {
                    Console.WriteLine($"{participant.Name} is currently participating in the war. So far has fought {participant.BattlesPlayed}, earned {participant.CardsEarned} cards and won {participant.Wins} battles.");
                }
            } else
            {
                Console.WriteLine($"Current clan {war.Clan.Name} status is {war.State}");
            }
            
            Console.ReadLine();
        }
    
    }
}
