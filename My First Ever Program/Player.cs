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
        }

        public void Interact(string aMove)
        {
            this.EvaluateResultPackage(myCurrentTarget.RunCommand(aMove));
        }

        internal void RollNewInteractable()
        {
            myCurrentTarget = null;

        }

        public void ForceSetTarget(IInteractable aInteractable)
        {
            myCurrentTarget = null;
            myCurrentTarget = aInteractable;
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

        public void SetSurroundings(IBiome aBiome)
        {
            Surroundings = new TemplateWorldTile(this, aBiome);
        }
        
        protected void EvaluateResultPackage(ResultPackage aPack)
        {
            Console.WriteLine(aPack.PrintResult());
        }
    }
}