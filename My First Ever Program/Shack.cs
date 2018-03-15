using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class Shack : BaseInteractable
    {

        public Shack()
        {
            InteractionString = "There seems to be smoke coming from a nearby shack";

            InteractionTable.Add("look", "You walk over to the shack and inspect it futher.");
            InteractionTable.Add("die", "You curl up and die.");
        }
        
    }
}