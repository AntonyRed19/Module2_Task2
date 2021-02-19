using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardShop
{
    public class Keyboard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public Currency Currency { get; set; }

        public TypeofKeyboard TypeofKeyboard { get; set; }

        public string Features { get; set; }
        public bool Backlight { get; set; }
    }
}
