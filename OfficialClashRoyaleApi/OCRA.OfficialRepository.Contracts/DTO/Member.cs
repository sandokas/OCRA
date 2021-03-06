﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OCRA.Repositories.Official.Contracts.DTO
{
    //TODO: This is actually a business object, should be a DTO and be mapped on Service
    public class Member
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; }
        public string LastSeen { get; set; }
        public int ExpLevel { get; set; }
        public int Trophies { get; set; }
        public Arena Arena { get; set; }
        public int ClanRank { get; set; }
        public int PreviousClanRank { get; set; }
        public int Donations { get; set; }
        public int DonationsReceived { get; set; }
    }
}
