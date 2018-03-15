using System;

namespace My_First_Ever_Program
{
    class Player
    {
        private string name;
        protected IWorldTile Surroundings;
        protected IInteractable myCurrentTarget;

        public Player(string v)
        {
            this.name = v;
            Surroundings = new ForestWorldTile(this);
        }

        public void Interact(string aMove)
        {
            this.EvaluateResultPackage(myCurrentTarget.RunCommand(aMove));
        }

        internal void RollNewInteractable()
        {
            myCurrentTarget = null;

        }

        public string GetState()
        {
            if(myCurrentTarget == null)
            {
                myCurrentTarget = Surroundings.GetInteractable();
                return myCurrentTarget.GetInteractionString();
            }
            else
            {
                return myCurrentTarget.GetInteractableStage();
            }
        }

        
        protected void EvaluateResultPackage(ResultPackage aPack)
        {
            Console.WriteLine(aPack.PrintResult());
        }
    }
}