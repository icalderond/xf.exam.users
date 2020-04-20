using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.exam.users.Views;

namespace xf.exam.users
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UsersPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
