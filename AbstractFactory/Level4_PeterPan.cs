using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concreate factorie implementation for the 4th level also known as the Peter Pan level.
    //it inherits the IDisneyFactory so it implements the methods of the interface
    public class Level4_PeterPan : IDisneyFactory
    {
        //creating Peter Pans Hero
        public IHero CreateHero()
        {
            return new PChildren(); //returning the specific charater for the level
        }
        //creating Peter Pans Villan
        public IWicked CreateWicked()
        {
            return new PCapHook();
        }
        //creating Peter Pans Weapons
        public IWeapon CreateWeapon()
        {
            return new PSword();
        }
        //creating Peter Pans Environment
        public IPlace CreatePlace()
        {
            return new PNeverland();
        }

    }
}
