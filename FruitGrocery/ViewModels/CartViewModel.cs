using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FruitGrocery.Models;

namespace FruitGrocery.ViewModels
{
    public class CartViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CartItem> Cart { get; set; }
        public decimal CartTotal => CalculateCartTotal();

        public CartViewModel()
        {
            Cart = new ObservableCollection<CartItem>(); 
        }


        public CartViewModel(ObservableCollection<CartItem> cart) 
            {
            Cart = cart;
        }

        private decimal CalculateCartTotal()
        {
            return Cart.Sum(item => item.TotalPrice);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

