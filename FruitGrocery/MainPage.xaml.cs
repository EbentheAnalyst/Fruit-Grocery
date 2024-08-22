using Microsoft.Maui.Controls;
using FruitGrocery.ViewModels;
using FruitGrocery.Models;

namespace FruitGrocery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddToCart_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var fruit = button.BindingContext as Fruit;
            var parent = (button.Parent as StackLayout);
            var quantityEntry = parent?.FindByName<Entry>("quantityEntry");
            int quantity = int.Parse(quantityEntry?.Text ?? "1");
            var viewModel = BindingContext as FruitsViewModel;
            viewModel.AddToCart(fruit, quantity);
        }

        private async void ViewCart_Clicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as FruitsViewModel;
            await Navigation.PushAsync(new CartPage(viewModel.Cart));
        }
    }
}
