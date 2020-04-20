using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.exam.users.ViewModels;

namespace xf.exam.users.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateUserPage : ContentPage
    {
        public CreateUserPageViewModel ViewModel;
        public CreateUserPage()
        {
            InitializeComponent();
            ViewModel = new CreateUserPageViewModel();
            BindingContext = ViewModel;
        }
    }
}