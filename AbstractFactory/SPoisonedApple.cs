using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the weapon specific to Snowwhite
    public class SPoisonedApple : IWeapon
    {
        public void TheDeathWeapon()
        {
            Console.WriteLine("The big shinny juiciy Poisoned apple from the stepmom Apple.");
        }
    }
}
