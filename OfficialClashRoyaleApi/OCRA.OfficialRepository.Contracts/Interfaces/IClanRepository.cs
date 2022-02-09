using System;
using System.Collections.Generic;
using System.Text;
using OCRA.Repositories.Official.Contracts.DTO;

namespace OCRA.Repositories.Official.Contracts.Interfaces
{
    public interface IClanRepository
    {
        IList<Member> GetClanMembersByTag(string tag);
        War GetCurrentWarByTag(string tag);
        Clan GetClanByTag(string tag);
        void GetCurrentRiverRaceByTag(string tag);
        void GetLastRiverRaceByTag(string tag);
    }
}
