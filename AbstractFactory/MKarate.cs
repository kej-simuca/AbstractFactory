using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the weapon specific to Mulan
    public class MKarate : IWeapon
    {
        public void TheDeathWeapon()
        {
            Console.WriteLine("Karate. Mulan is the top Karate fighter utulize the skill to max.");
        }
    }
}
