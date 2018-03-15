using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class Cave : BaseInteractable
    {

        public Cave()
        {
            InteractionString = "You spot a dark dank cave";
            InteractionTable.Add("run", "You turn tail and run as fast as you can.");
            InteractionTable.Add("hide", "You dig a small hole to lie in");
        }

    }
}