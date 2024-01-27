using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the wicked specific to WallE
    public class WTrash : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("Trash.");
        }
    }
}