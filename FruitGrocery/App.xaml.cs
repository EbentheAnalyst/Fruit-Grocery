//Sets the initial page to LoginPage.

using Microsoft.Maui.Controls;

namespace FruitGrocery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
