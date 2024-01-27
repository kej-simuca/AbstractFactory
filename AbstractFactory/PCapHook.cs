using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the wicked specific to Peter Pan
    public class PCapHook : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("Cap. Hook. His biggest dream is to kick out of Neverland Peter and the kids.");
        }
    }
}