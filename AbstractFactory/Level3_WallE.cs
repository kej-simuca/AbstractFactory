using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concreate factorie implementation for the third level also known as the WallE level.
    //it inherits the IDisneyFactory so it implements the methods of the interface
    public class Level3_WallE : IDisneyFactory
    {
        //creating WallE Hero, Villan, Weapon and setting the background
        public IHero CreateHero()
        {
            return new WWallE(); //returning the specific charater for the level
        }

        public IWicked CreateWicked()
        {
            return new WTrash();
        }

        public IWeapon CreateWeapon()
        {
            return new WRecycle();
        }
        public IPlace CreatePlace()
        {
            return new WEarth();
        }

    }
}