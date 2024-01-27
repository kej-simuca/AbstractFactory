using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the villian specific to Snowwhite
    public class SStepmom : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("The stepmom. Get Snowwhite to eat the poisoned APPLE.");
        }
    }
}
