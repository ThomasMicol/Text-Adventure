using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Ever_Program
{
    class Actionable
    {

        public static ResultPackage Investigate(object aPlayer)
        {
            Console.WriteLine("You look and see nothing");
            return new ResultPackage();
        }

        public static void Leave(Player aPlayer)
        {
            aPlayer.RollNewInteractable();
        }
    }
}
