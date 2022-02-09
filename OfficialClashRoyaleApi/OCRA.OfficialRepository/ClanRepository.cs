using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web;
using Newtonsoft.Json;
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
                File.WriteAllText($"d:\\tmp\\clashroyale\\{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")}.clan.json", jsonResponse);
//                clan = JsonConvert.DeserializeObject<Clan>(jsonResponse);
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
                    File.WriteAllText($"d:\\tmp\\clashroyale\\{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")}.clanmembers.json", jsonResponse);
//                    ClanMembers clanMembers = JsonConvert.DeserializeObject<ClanMembers>(jsonResponse);
//                    members = clanMembers.Items;
                }

            }
            return members;
        }

        public War GetCurrentWarByTag(string tag)
        {

            War war = null;
            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}/currentwar";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string jsonResponse = content.ReadAsStringAsync().Result;
                    //                    war = JsonConvert.DeserializeObject<War>(jsonResponse);
                    File.WriteAllText($"d:\\tmp\\clashroyale\\{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")}.clanwar.json", jsonResponse);
                    ;
                }

            }
            return war;

        }

        public void GetLastRiverRaceByTag(string tag)
        {

            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}/riverracelog?limit=1";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string jsonResponse = content.ReadAsStringAsync().Result;
                    //                    war = JsonConvert.DeserializeObject<War>(jsonResponse);
                    File.WriteAllText($"d:\\tmp\\clashroyale\\{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")}.clanCurrentRiver.json", jsonResponse);
                    ;
                }

            }

        }
        public void GetCurrentRiverRaceByTag(string tag)
        {

            string url = $"v1/clans/{HttpUtility.UrlEncode(tag)}/currentriverrace";
            using (HttpClient client = OfficialRestApi.HttpClientFactory())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string jsonResponse = content.ReadAsStringAsync().Result;
                    //                    war = JsonConvert.DeserializeObject<War>(jsonResponse);
                    File.WriteAllText($"d:\\tmp\\clashroyale\\{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")}.clanLastRiver.json", jsonResponse);
                    ;
                }

            }

        }
    }
}
