using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using xf.exam.users.Models;
using xf.exam.users.Services;

namespace xf.exam.users.ViewModels
{
    public class UsersPageViewModel : NotificationEnabledObject
    {
        public UsersPageViewModel()
        {
            _ = LoadData();
        }

        private async Task LoadData()
        {
            var users = await UsersBL.GetUsers();
            UserList = new ObservableCollection<User>(users);
        }

        private UsersBL _UsersBL;
        public UsersBL UsersBL
        {
            get => _UsersBL = _UsersBL ?? new UsersBL();
        }

        private ObservableCollection<User> _UserList;
        public ObservableCollection<User> UserList
        {
            get => _UserList;
            set => Set(ref _UserList, value);
        }
    }
}
