using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concreate factorie implementation for the fifth level also known as the Mulan level.
    //it inherits the IDisneyFactory so it implements the methods of the interface
    public class Level5_Mulan : IDisneyFactory
    {
        //creating Mulan's Hero, Villan, Weapon and setting the background
        public IHero CreateHero()
        {
            return new MMulan(); //returning the specific charater for the level
        }

        public IWicked CreateWicked()
        {
            return new MHunArmy();
        }

        public IWeapon CreateWeapon()
        {
            return new MKarate();
        }
        public IPlace CreatePlace()
        {
            return new MChina();
        }

    }
}