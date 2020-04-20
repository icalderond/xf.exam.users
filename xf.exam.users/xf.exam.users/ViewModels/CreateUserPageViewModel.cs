using System;
using Xamarin.Forms;
using xf.exam.users.Models;
using xf.exam.users.Services;

namespace xf.exam.users.ViewModels
{
    public class CreateUserPageViewModel : NotificationEnabledObject
    {
        public CreateUserPageViewModel()
        {
            User = new User();
        }
        public event EventHandler<GenericEventArgs<User>> AddUser_Completed;

        private UsersBL _UsersBL;
        public UsersBL UsersBL
        {
            get => _UsersBL = _UsersBL ?? new UsersBL();
        }

        private User _User;
        public User User
        {
            get => _User;
            set => Set(ref _User, value);
        }

        private ActionCommand<string> _AddUserCommand;
        public ActionCommand<string> AddUserCommand
        {
            get => _AddUserCommand = _AddUserCommand ?? new ActionCommand<string>(
               async (param) =>
                {
                    await App.Current.MainPage.Navigation.PopAsync();
                    AddUser_Completed?.Invoke(this, new GenericEventArgs<User>(User));
                });
        }

        private ActionCommand<string> _ChangeImageCommand;
        public ActionCommand<string> ChangeImageCommand
        {
            get => _ChangeImageCommand = _ChangeImageCommand ?? new ActionCommand<string>(
                async (param) => User.ProfileImage = await UsersBL.GetProfileImage());
        }
    }
}
