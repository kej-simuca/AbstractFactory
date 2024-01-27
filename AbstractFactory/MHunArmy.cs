using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the wicked specific to Mulan
    public class MHunArmy : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("Hun Army. They want to tae controll over China and Kill the King.");
        }
    }
}
