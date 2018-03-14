using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class Cave : IInteractable
    {
        protected string InteractionString;
        protected Dictionary<string, string> InteractionTable = new Dictionary<string, string>();
        protected string UnrecognizedMove = "Why would you want to do that?";

        public Cave()
        {
            InteractionString = "You spot a dark dank cave";
            InteractionTable.Add("run", "You turn tail and run as fast as you can.");
            InteractionTable.Add("hide", "You dig a small hole to lie in");
        }

        public string GetInteractionString()
        {
            return InteractionString;
        }

        public ResultPackage RunCommand(string aMove)
        {

            if (InteractionTable.TryGetValue(aMove, out string aOut))
            {
                Console.WriteLine(aOut);
            }

            return new ResultPackage();
        }

    }
}