using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Ever_Program
{
    class BaseInteractable : IInteractable
    {
        protected IStageHandler myStageHandler = new StageHandler();
        protected Actionable myActionable = new Actionable();
        protected Player myPlayer;
        protected string Name;
        protected string DiscoveredString;
        protected Dictionary<string, string[]> InteractionTable = new Dictionary<string, string[]>();
        protected string UnrecognizedMove = "Why would you want to do that?";

        public string GetInteractableStage(){ return myStageHandler.GetCurrentStage();}
        public string GetInteractionString() { return DiscoveredString; }
        public string GetNameString() { return Name;  }


        public ResultPackage RunCommand(string aMove)
        {

            if (InteractionTable.TryGetValue(aMove, out string[] aOut))
            {
                Console.WriteLine(aOut[0]);
                var aType = myActionable.GetType();
                var aMeth = aType.GetMethod(aOut[1]);
                object[] param = new object[1] { myPlayer };
                aMeth.Invoke(null, param);
            }
            else
            {
                Console.WriteLine(this.UnrecognizedMove);
            }

            return new ResultPackage();
        }

        public void AddInteraction(string key, string[] value)
        {
            InteractionTable.Add(key, value);
        }
    }
}
