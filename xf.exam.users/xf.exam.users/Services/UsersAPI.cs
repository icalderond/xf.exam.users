using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace xf.exam.users.Services
{
    public class UsersAPI
    {
        private readonly HttpClient httpClient;
        private readonly string EndPointUsers = $"https://gorest.co.in/public-api/users?_format=json&access-token={AppSettings.TokenGorest}";
        private readonly string EndPointProfileImage = $"https://randomuser.me/api/?inc=picture";

        public UsersAPI()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> GetUsers()
        {
            HttpResponseMessage response = await httpClient.GetAsync(EndPointUsers);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var jsonParsed = JObject.Parse(responseBody);

            return jsonParsed["result"].ToString();
        }

        public async Task<string> GetProfileImage()
        {
            HttpResponseMessage response = await httpClient.GetAsync(EndPointProfileImage);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var jsonParsed = JObject.Parse(responseBody);

            return jsonParsed["results"][0]["picture"]["large"].ToString();
        }
    }
}
