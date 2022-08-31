using System.Net.Http.Headers;

namespace LoyaltyAPI.Helpers
{
    public class ApiHelper
    {
        private static IConfiguration _config;

        public ApiHelper(IConfiguration config)
        {
            _config = config;
        }
        public static HttpClient Client { get; set; }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            string baseUrl = _config.GetValue<string>("APISettings:APIUrl");
            Client.BaseAddress = new Uri(baseUrl);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
