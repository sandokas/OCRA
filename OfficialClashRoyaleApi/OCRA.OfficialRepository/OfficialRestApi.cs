using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace OCRA.Repositories.Official
{
    public static class OfficialRestApi
    {
        //TODO: Read from configurations
        private static string BaseAddress { get;  } = "https://api.clashroyale.com/";
        private static string ApiToken { get; } = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImI4OWExZGVlLWVmZWQtNDk0My04NDQwLWE2YTFiYzdlN2JkOSIsImlhdCI6MTUzNDUyMjMwMywic3ViIjoiZGV2ZWxvcGVyL2NhYzdmZTAwLWI5NWMtZGFhOC0xNTczLTdhMmQ0ZGY3NDdhMSIsInNjb3BlcyI6WyJyb3lhbGUiXSwibGltaXRzIjpbeyJ0aWVyIjoiZGV2ZWxvcGVyL3NpbHZlciIsInR5cGUiOiJ0aHJvdHRsaW5nIn0seyJjaWRycyI6WyIxOTUuMjMuMi4xNDIiXSwidHlwZSI6ImNsaWVudCJ9XX0.pe0M8r82nlfWFZ8ZZmijqKfOYnltB3VFpZIeuYLkdX6f66dnLUIXLTZrphkLZIYayVWTCbEMivUC0Udv-Va8fA";
        private static string ContentType { get; } = "application/json";
        private static readonly HttpClient client = new HttpClient();
        public static HttpClient HttpClientFactory()
        {
            client.BaseAddress = new Uri(BaseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiToken);
            return client;
        }
    }
}
