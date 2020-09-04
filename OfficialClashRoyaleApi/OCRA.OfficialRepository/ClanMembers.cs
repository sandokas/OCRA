using OCRA.Repositories.Official.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OCRA.Repositories.Official
{
    internal class ClanMembers
    {
        public IList<Member> Items { get; set; }
    }
}
