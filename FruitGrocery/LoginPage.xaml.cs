using Microsoft.Maui.Controls;
using FruitGrocery.ViewModels;

namespace FruitGrocery
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
