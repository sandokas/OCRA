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

            IClanRepository clanRepository = new ClanRepository();
            IList<Member> members = clanRepository.GetClanMembersByTag("#8YQ9828");
            foreach (Member member in members)
            {
                Console.WriteLine($"Nome do membro {member.Name} que tem {member.Trophies} e está na arena {member.Arena?.Name.ToString(culture)}. Tem o cargo de {member.Role.ToString()}.");
            }
            Console.ReadLine();
        }
    
    }
}
