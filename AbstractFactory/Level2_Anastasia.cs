using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concreate factorie implementation for the 2nd level also known as the Anastasia level.
    //it inherits the IDisneyFactory so it implements the methods of the interface
    public class Level2_Anastasia : IDisneyFactory
    {
        //creating Anastasia's Hero, Villan, Weapon and setting the background
        public IHero CreateHero()
        {
            return new ADimitri(); //returning the specific charater for the level
        }

        public IWicked CreateWicked()
        {
            return new ARasputin();
        }

        public IWeapon CreateWeapon()
        {
            return new AGhost();
        }
        public IPlace CreatePlace()
        {
            return new APonteAlexandreIII();
        }

    }
}