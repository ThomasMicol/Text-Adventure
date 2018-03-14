using System;

namespace My_First_Ever_Program
{

    interface IInteractable
    {
        string GetInteractionString();
        ResultPackage RunCommand(string aMove);

        
    }
}