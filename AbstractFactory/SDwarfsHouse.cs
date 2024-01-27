using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to Snowwhite
    public class SDwarfsHouse : IPlace
    {
        public void Display()
        {
            Console.WriteLine("The dwarfs house and the forest.");
        }
    }
}
