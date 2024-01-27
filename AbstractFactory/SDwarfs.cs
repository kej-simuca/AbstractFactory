using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the hero specific to Snowwhite
    public class SDwarfs : IHero
    {
        public void Act()
        {
            Console.WriteLine("The 7 Dwarfs. They have to find the Prince.");
        }
    }
}
