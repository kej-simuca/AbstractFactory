using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //the abstract product interface for the Weapon used in the game at each level

    public interface IWeapon
    {
        //this method is to determine the weapon the player uses to fight (related to the original story)
        void TheDeathWeapon();
    }
}