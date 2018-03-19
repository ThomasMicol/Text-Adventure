using System;

namespace My_First_Ever_Program
{

    interface IInteractable
    {
        string GetInteractionString();
        string GetNameString();
        ResultPackage RunCommand(string aMove);
        void AddInteraction(string key, string[] value);
        string GetInteractableStage();
        
    }
}