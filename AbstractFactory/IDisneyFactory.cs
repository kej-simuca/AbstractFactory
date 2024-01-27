using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{ 
    //declaring the abstract factory interface
    public interface IDisneyFactory
    {
    //methods to create different types of objects respectively the hero; villan; weapon; and the place 
        IHero CreateHero();
        IWicked CreateWicked();
        IWeapon CreateWeapon();
        IPlace CreatePlace();
    }
}
