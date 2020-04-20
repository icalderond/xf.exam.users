using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.exam.users.ViewModels;

namespace xf.exam.users.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersPage : ContentPage
    {
        public UsersPage()
        {
            InitializeComponent();
            var ViewModel = new UsersPageViewModel();
            BindingContext = ViewModel;
        }
    }
}