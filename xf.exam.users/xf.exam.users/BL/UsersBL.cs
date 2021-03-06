﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using xf.exam.users.Models;

namespace xf.exam.users.Services
{
    public class UsersBL
    {
        private UsersAPI _UsersAPI;
        public UsersAPI UsersAPI
        {
            get => _UsersAPI = _UsersAPI ?? new UsersAPI();
        }

        public async Task<List<User>> GetUsers()
        {
            var model = await UsersAPI.GetUsers();
            var listUsers = JsonConvert.DeserializeObject<List<User>>(model);
            for (int i = 0; i < listUsers.Count; i++)
                listUsers[i].ProfileImage = await UsersAPI.GetProfileImage();
            return listUsers;
        }

        public async Task<string> GetProfileImage() => await UsersAPI.GetProfileImage();
    }
}
