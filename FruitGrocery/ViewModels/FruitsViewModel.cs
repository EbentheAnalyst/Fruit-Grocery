using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FruitGrocery.Models;

namespace FruitGrocery.ViewModels
{
    public class FruitsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Fruit> Fruits { get; set; }
        public ObservableCollection<CartItem> Cart { get; set; }
        public decimal CartTotal => CalculateCartTotal();

        public FruitsViewModel()
        {
            Fruits = new ObservableCollection<Fruit>
            {
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m },
                new Fruit { Name = "Apple", Image = "apple.png", Price = 0.5m },
                new Fruit { Name = "Banana", Image = "banana.png", Price = 0.3m }
            };

            Cart = new ObservableCollection<CartItem>();
        }

        public void AddToCart(Fruit fruit, int quantity)
        {
            var existingItem = Cart.FirstOrDefault(c => c.Fruit.Name == fruit.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Cart.Add(new CartItem { Fruit = fruit, Quantity = quantity });
            }
            OnPropertyChanged(nameof(CartTotal));
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
