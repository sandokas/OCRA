﻿namespace OCRA.Repositories.Official.Contracts.DTO
{
    public class Clan
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public int BadgeId { get; set; }
        public int ClanScore { get; set; }
        public int Participants { get; set; }
        public int BattlesPlayed { get; set; }
        public int Wins { get; set; }
        public int Crowns { get; set; }
    }
}