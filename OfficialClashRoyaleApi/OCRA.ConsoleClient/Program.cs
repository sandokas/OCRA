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
            string clanTag = "#8YQ9828";

            IClanRepository clanRepository = new ClanRepository();
            clanRepository.GetClanMembersByTag(clanTag);
            clanRepository.GetClanByTag(clanTag);
            clanRepository.GetCurrentRiverRaceByTag(clanTag);
            clanRepository.GetLastRiverRaceByTag(clanTag);

            Console.ReadLine();
        }
    
    }
}
