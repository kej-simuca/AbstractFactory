using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the hero specific to WallE
    public class WWallE : IHero
    {
        public void Act()
        {
            Console.WriteLine("Wall-E. He has to collect and recycle the trash on Earth.");
        }
    }
}