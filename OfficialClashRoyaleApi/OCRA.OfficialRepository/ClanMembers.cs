using Newtonsoft.Json;
using OCRA.Repositories.Official.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCRA.Repositories.Official
{
    internal class ClanMembers
    {
        //TODO: Newtonsoft.Json should not be a dependency on Contract layer, to be implemented Mapper Object
        [JsonProperty("items")]
        public IList<Member> Items { get; set; }
    }
}
