using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the hero specific to Mulan
    public class MMulan : IHero
    {
        public void Act()
        {
            Console.WriteLine("Mulan. She fights against Hun Army to protect China and the King.");
        }
    }
}