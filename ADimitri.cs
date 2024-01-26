using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the hero specific to Anastasia
    public class ADimitri : IHero
    {
        public void Act()
        {
            Console.WriteLine("Dimitri. He Atacks Rasputin and his creatures.");
        }
    }
}
