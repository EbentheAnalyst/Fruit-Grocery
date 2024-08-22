using Microsoft.Maui.Controls;

namespace FruitGrocery
{
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }

        private async void BuyNow_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string address = addressEntry.Text;
            string city = cityEntry.Text;
            string postalCode = postalCodeEntry.Text;

            // Here you would normally process the order (e.g., save the order details, contact a backend service, etc.)
            // For this example, we'll just display an alert.

            await DisplayAlert("Order Placed", $"Thank you, {name}! Your order has been placed.", "OK");

            // Navigate back to the main page after placing the order
            await Navigation.PopToRootAsync();
        }
    }
}
