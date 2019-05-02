using Newtonsoft.Json;
using QNTMWPFUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QNTMWPFUserInterface.Helpers
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient ApiClient { get; set; }

        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];

            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(api);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task Register(string userName, string passWord)
        {
            var req = new StringContent(JsonConvert.SerializeObject(new { username = userName, password = passWord }), Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiClient.PostAsync("auth/register", req))
            {
                if (response.IsSuccessStatusCode)
                {
                    // do a popup or something lol
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<AuthenticatedUser> Login(string userName, string passWord)
        {
            var req = new StringContent(JsonConvert.SerializeObject(new { username = userName, password = passWord }), Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiClient.PostAsync("auth/login", req))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    Console.WriteLine(result.Token);
                    Console.WriteLine(result.UserName);
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
