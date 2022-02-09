using System.Collections.Generic;

namespace OCRA.Repositories.Official.Contracts.DTO
{
    public class Clan
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public int BadgeId { get; set; }
        public int Fame { get; set; }
        public int RepairPoints { get; set; }
        public string FinishTime { get; set; }
        public IList<Participant> Participants { get; set; }
        public int ClanScore { get; set; }
        public int BattlesPlayed { get; set; }
        public int Wins { get; set; }
        public int Crowns { get; set; }
        public int RequiredTrophies { get; set; }
        public int DonationsPerWeek { get; set; }
        public IList<Member> MemberList { get; set; }

    }
}