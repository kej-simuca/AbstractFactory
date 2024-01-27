using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //the abstract product interface for the Place in the game
    public interface IPlace
    {
        //this method is to determine the location of the game (related to the original story)
        void Display();
    }
}