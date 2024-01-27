using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //the abstract product interface for the Wicked used in the game at each level
    public interface IWicked
    {
        //this method is to determine why the wicked dislikes or why it is fighting the hero (related to the original story)
        void Attack();
    }
}