using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to Mulan
    public class MChina : IPlace
    {
        public void Display()
        {
            Console.WriteLine("The war between Mulan and Hun Army is located in China.");
        }
    }
}
