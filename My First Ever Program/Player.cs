using System;

namespace My_First_Ever_Program
{
    internal class Player
    {
        private string name;
        protected IWorldTile Surroundings = new ForestWorldTile();
        protected IInteractable myCurrentTarget;

        public Player(string v)
        {
            this.name = v;
        }

        public void Interact(string aMove)
        {
            this.EvaluateResultPackage(myCurrentTarget.RunCommand(aMove));
        }

        public string GetState()
        {
            myCurrentTarget = Surroundings.GetInteractable();
            return myCurrentTarget.GetInteractionString();
        }
        
        protected void EvaluateResultPackage(ResultPackage aPack)
        {
            Console.WriteLine(aPack.PrintResult());
        }
    }
}