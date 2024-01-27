using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concreate factorie implementation for the first level also known as the snowhite level.
    //it inherits the IDisneyFactory so it implements the methods of the interface
    public class Level1_SnowWhite : IDisneyFactory
    {
        //creating Snowwhite Hero, Villan, Weapon and setting the background
        public IHero CreateHero()
        {
            return new SDwarfs(); //returning the specific charater for the level
        }

        public IWicked CreateWicked()
        {
            return new SStepmom();
        }

        public IWeapon CreateWeapon()
        {
            return new SPoisonedApple();
        }
        public IPlace CreatePlace()
        {
            return new SDwarfsHouse();
        }

    }
}
