using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
            return JsonConvert.DeserializeObject<List<User>>(model);
        }
    }
}
