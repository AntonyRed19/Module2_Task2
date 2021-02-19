using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardShop
{
    public class KeyboardServices
    {
        private readonly Keyboard[] _keyboards;
        private readonly Basket _baskets;

        public KeyboardServices()
        {
            _keyboards = new Keyboard[]
            {
            new Keyboard() { Id = 1, Brand = "Logitech", Backlight = true, Name = "Keyboard 1", Price = 3300, Currency = Currency.UAN, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Mechanical },
            new Keyboard() { Id = 2, Brand = "Hyper X", Backlight = true, Name = "Keyboard 2", Price = 2300, Currency = Currency.USD, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Mechanical },
            new Keyboard() { Id = 3, Brand = "SteelSeries", Backlight = false, Name = "Keyboard 3", Price = 4300, Currency = Currency.UAN, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Hybrid },
            new Keyboard() { Id = 4, Brand = "Zowie", Backlight = false, Name = "Keyboard 4", Price = 1300, Currency = Currency.UAN, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Mechanical },
            new Keyboard() { Id = 5, Brand = "A4-tech", Backlight = false, Name = "Keyboard 5", Price = 4320, Currency = Currency.USD, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Membrane },
            new Keyboard() { Id = 6, Brand = "MSI", Backlight = false, Name = "Keyboard 6", Price = 1700, Currency = Currency.UAN, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Mechanical },
            new Keyboard() { Id = 7, Brand = "Razor", Backlight = true, Name = "Keyboard 7", Price = 300, Currency = Currency.UAN, Features = " Hardware, software", TypeofKeyboard = TypeofKeyboard.Hybrid },
            };
        }

        public Keyboard[] GetAll()
        {
            for (int i = 0; i < _keyboards.Length; i++)
            {
                _keyboards.ToString();
                Console.WriteLine(_keyboards[i]);
            }

            return _keyboards;
        }

        public Keyboard[] FilterbyBacklight(bool backlight)
        {
            for (int i = 0; i < _keyboards.Length; i++)
            {
                if (backlight == false)
                {
                    _keyboards[i] = _baskets.Keyboards;
                    Console.WriteLine(_keyboards);
                }
            }

            return _keyboards;
        }
    }
}
