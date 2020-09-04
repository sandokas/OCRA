using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web;
using OCRA.Repositories.Official.Contracts.DTO;
using OCRA.Repositories.Official.Contracts.Interfaces;

namespace OCRA.Repositories.Official
{
    public class ClanRepository : IClanRepository
    {
        public Clan GetClanByTag(string tag)
        {
            Clan clan = new Clan();
            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                HttpContent content = response.Content;
                string jsonResponse = content.ReadAsStringAsync().Result;
                System.IO.File.WriteAllText(@"d:\clan.json", jsonResponse);
                clan = JsonSerializer.Deserialize<Clan>(jsonResponse, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
            }

                return clan;
        }

        public IList<Member> GetClanMembersByTag(string tag)
        {
            IList<Member> members = null;
            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}/members";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string jsonResponse = content.ReadAsStringAsync().Result;
                    System.IO.File.WriteAllText(@"d:\clanMembers.json", jsonResponse);
                    ClanMembers clanMembers = JsonSerializer.Deserialize<ClanMembers>(jsonResponse,new JsonSerializerOptions{ PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                    members = clanMembers.Items;
                }

            }
            return members;
        }

        public RiverRace GetCurrentRiverRaceByTag(string tag)
        {

            RiverRace riverRace = new RiverRace();
            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}/currentriverrace";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string jsonResponse = content.ReadAsStringAsync().Result;
                    System.IO.File.WriteAllText(@"d:\currentriverace.json", jsonResponse);
                    riverRace = JsonSerializer.Deserialize<RiverRace>(jsonResponse, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                    ;
                }

            }
            return riverRace;

        }
    }
}
