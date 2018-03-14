using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class Shack : IInteractable
    {
        protected string InteractionString;
        protected Dictionary<string, string> InteractionTable = new Dictionary<string, string>();
        protected string UnrecognizedMove = "Why would you want to do that?";


        public Shack()
        {
            InteractionString = "There seems to be smoke coming from a nearby shack";
            InteractionTable.Add("look", "You walk over to the shack and inspect it futher.");
            InteractionTable.Add("die", "You curl up and die.");
        }

        public string GetInteractionString()
        {
            return InteractionString;
        }
        
        public ResultPackage RunCommand(string aMove)
        {
            
            if(InteractionTable.TryGetValue(aMove, out string aOut))
            {
                Console.WriteLine(aOut);
            }
            
            return new ResultPackage();
        }
    }
}