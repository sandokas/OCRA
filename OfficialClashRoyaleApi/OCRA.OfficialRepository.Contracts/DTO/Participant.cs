namespace OCRA.Repositories.Official.Contracts.DTO
{
    public class Participant
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public int CardsEarned { get; set; }
        public int BattlesPlayed { get; set; }
        public int Wins { get; set; }
    }
}