using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //to begin with I wannna thank me
    //this is the client class. this class 
    public class GameLevel
    {
        //refernce to the IDisneyFactory, to create the game elements
        private readonly IDisneyFactory _cartoonFactory;
        //the constructor through each the reference taken from the abstract factory is initialized to be utilized later on; globally avaiable
        public GameLevel(IDisneyFactory cartoonFactory)
        {
            _cartoonFactory = cartoonFactory;
        }

        //this method from the name creats the level. it also displays the elements in the output 
        public void CreateLevel()
        {
            //creates the elements using the factory
            var hero = _cartoonFactory.CreateHero();
            var wicked = _cartoonFactory.CreateWicked();
            var weapon = _cartoonFactory.CreateWeapon();
            var place = _cartoonFactory.CreatePlace();

            //the message that announces the first level 
            Console.WriteLine("******************************** Loading Level **********************************************\n");
            //displays the info about the level     
            Console.Write("The Hero of the level is and he should: "); 
            hero.Act();

            Console.Write("The villan is and he aims: ");
            wicked.Attack();

            Console.Write("The Weapon to be utilized in this level: ");
            weapon.TheDeathWeapon();

            Console.Write("This is taking place is: ");
            place.Display();
            
        }
    }
}
