using OCRA.Repositories.Official;
using OCRA.Repositories.Official.Contracts.DTO;
using OCRA.Repositories.Official.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;

namespace OCRA.ConsoleClient
{
    class Program
    {
        public static string GetCurrentIpAddress()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://icanhazip.com");
            var result = client.GetAsync("").Result;
            return result.Content.ReadAsStringAsync().Result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"Your IP Address: {GetCurrentIpAddress()}");

            CultureInfo culture = new CultureInfo("pt-PT");
            Console.OutputEncoding = Encoding.UTF8;
            string clanTag = "#8YQ9828";

            IClanRepository clanRepository = new ClanRepository();

            Clan clan = clanRepository.GetClanByTag(clanTag);
            RiverRace riverRace = clanRepository.GetCurrentRiverRaceByTag(clanTag);

            Console.WriteLine($"Current clan {riverRace.Clan.Name} war status is {riverRace.State}");
            
            foreach (Participant participant in riverRace.Clan.Participants)
            {
                Console.WriteLine($"{participant.Name} is currently participating in the war. So far has earned {participant.Fame} fame, and repaired {participant.RepairPoints} points.");
            }

            foreach (var member in clan.MemberList)
            {
                Console.WriteLine($"{member.Name} ({member.ExpLevel}) has donated {member.Donations} and received {member.DonationsReceived}. He is in {member.Arena.Name} with {member.Trophies} trophies.");
            }
            
            Console.ReadLine();
        }
    
    }
}
