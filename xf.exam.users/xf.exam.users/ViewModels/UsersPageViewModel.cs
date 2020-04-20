using System.Collections.ObjectModel;
using System.Threading.Tasks;
using xf.exam.users.Models;
using xf.exam.users.Services;
using xf.exam.users.Views;

namespace xf.exam.users.ViewModels
{
    public class UsersPageViewModel : NotificationEnabledObject
    {
        CreateUserPage createUserPage;

        public UsersPageViewModel()
        {
            _ = LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                IsBusy = true;
                var users = await UsersBL.GetUsers();
                UserList = new ObservableCollection<User>(users);
            }
            catch (System.Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }
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

        private ActionCommand<string> _AddUserCommand;
        public ActionCommand<string> AddUserCommand
        {
            get => _AddUserCommand = _AddUserCommand ?? new ActionCommand<string>(
                async (x) =>
                {
                    createUserPage = new CreateUserPage();
                    await App.Current.MainPage.Navigation.PushAsync(createUserPage);
                    createUserPage.ViewModel.AddUser_Completed -= (s, a) => UserList.Add(a.Result);
                    createUserPage.ViewModel.AddUser_Completed += (s, a) => UserList.Add(a.Result);
                });
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get => _IsBusy;
            set => Set(ref _IsBusy, value);
        }
    }
}
