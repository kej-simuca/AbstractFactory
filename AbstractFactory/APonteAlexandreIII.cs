using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to Anastasia
    public class APonteAlexandreIII : IPlace
    {
        public void Display()
        {
            Console.WriteLine("Pont Alexandre III is the place where the last confrontation between Anastasia, Rasputin, Dimitri, the white mouse, and the rest of the ghosts happens.");
        }
    }
}
