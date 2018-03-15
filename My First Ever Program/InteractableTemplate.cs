using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Ever_Program
{
    class InteractableTemplate : BaseInteractable
    {
        public InteractableTemplate(string aName, string aDiscoveredString)
        {
            Name = aName;
            DiscoveredString = aDiscoveredString;
        }
    }
}
