using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to WallE
    public class WEarth : IPlace
    {
        public void Display()
        {
            Console.WriteLine("Earth. It is full of trash and inhabitabile.");
        }
    }
}
