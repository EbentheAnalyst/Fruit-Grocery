using Microsoft.Maui.Controls;
using FruitGrocery.ViewModels;
using FruitGrocery.Models;
using System.Collections.ObjectModel;

namespace FruitGrocery
{
    public partial class CartPage : ContentPage
    {
       
        public CartPage()
        {
            InitializeComponent();
            BindingContext = new CartViewModel();
        }
        
        public CartPage(ObservableCollection<CartItem> cart)
        {
            InitializeComponent();
            BindingContext = new CartViewModel(cart);
        }

        private async void Checkout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckoutPage());
        }
    }
}
