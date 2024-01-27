using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to Peter Pan
    public class PNeverland : IPlace
    {
        public void Display()
        {
            Console.WriteLine("Peter Pan and Cap Hook live in Neverland and always fight there.");
        }
    }
}
