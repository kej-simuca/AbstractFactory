using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the weapon specific to WallE
    public class WRecycle : IWeapon
    {
        public void TheDeathWeapon()
        {
            Console.WriteLine("RIcycle. Only recycling correctly saves Earth.");
        }
    }
}