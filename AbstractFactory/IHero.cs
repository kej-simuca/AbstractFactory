using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //the abstract product interface for the Hero in the game
    public interface IHero
    {
        //this method is to determine how shall the hero act (related to the original story)
        void Act();
    }
}
