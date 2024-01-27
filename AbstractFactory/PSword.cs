using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the weapon specific to Peter Pan
    public class PSword : IWeapon
    {
        public void TheDeathWeapon()
        {
            Console.WriteLine("Swords. They are the element to be used against the Pirates.");
        }
    }
}