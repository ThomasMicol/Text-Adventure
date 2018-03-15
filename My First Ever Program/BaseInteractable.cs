using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Ever_Program
{
    class BaseInteractable : IInteractable
    {
        protected IStageHandler myStageHandler;
        protected string Name;
        protected string DiscoveredString;
        protected Dictionary<string, string> InteractionTable = new Dictionary<string, string>();
        protected string UnrecognizedMove = "Why would you want to do that?";

        public string GetInteractableStage()
        {
            return myStageHandler.GetCurrentStage();
        }

        public string GetInteractionString()
        {
            return DiscoveredString;
        }

        public ResultPackage RunCommand(string aMove)
        {

            if (InteractionTable.TryGetValue(aMove, out string aOut))
            {
                Console.WriteLine(aOut);
            }

            return new ResultPackage();
        }

        public void AddInteraction(string key, string value)
        {
            InteractionTable.Add(key, value);
        }
    }
}
