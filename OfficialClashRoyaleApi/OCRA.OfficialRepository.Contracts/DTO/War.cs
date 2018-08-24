using System;
using System.Collections.Generic;
using System.Text;

namespace OCRA.Repositories.Official.Contracts.DTO
{
    public class War
    {
        public string State { get; set; }
        public string WarEndTime { get; set; }
        public Clan Clan { get; set; }
        public IList<Participant> Participants { get; set; }
    }
}
