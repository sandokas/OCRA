using System;
using System.Collections.Generic;
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
                    ClanMembers clanMembers = JsonConvert.DeserializeObject<ClanMembers>(jsonResponse);
                    members = clanMembers.Items;
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
                    war = JsonConvert.DeserializeObject<War>(jsonResponse);
                    ;
                }

            }
            return war;

        }
    }
}
