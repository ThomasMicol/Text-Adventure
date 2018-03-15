using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class Shack : BaseInteractable
    {

        public Shack()
        {
            DiscoveredString = "There seems to be smoke coming from a nearby shack";

            InteractionTable.Add("look", "You walk over to the shack and inspect it futher.");
            InteractionTable.Add("die", "You curl up and die.");
        }
        
    }
}