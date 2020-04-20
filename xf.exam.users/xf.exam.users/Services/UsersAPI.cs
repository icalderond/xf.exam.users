﻿using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;

namespace xf.exam.users.Services
{
    public class UsersAPI
    {
        private readonly WebClient client;
        private readonly string EndPointUsers = $"https://gorest.co.in/public-api/users?_format=json&access-token={AppSettings.TokenGorest}";
        private readonly string EndPointProfileImage = $"https://randomuser.me/api/?inc=picture";

        public UsersAPI()
        {
            client = new WebClient();
        }


        public async Task<string> GetUsers()
        {
            var json = await client.DownloadStringTaskAsync(new Uri(EndPointUsers));
            var jsonParsed = JObject.Parse(json);
            return jsonParsed["result"].ToString();
        }

        public async Task<string> GetProfileImage()
        {
            var json = await client.DownloadStringTaskAsync(new Uri(EndPointProfileImage));
            var jsonParsed = JObject.Parse(json);
            return jsonParsed["results"][0]["picture"]["large"].ToString();
        }
    }
}
