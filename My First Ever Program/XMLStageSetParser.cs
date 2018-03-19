using System.Collections.Generic;
using System.Xml;

namespace My_First_Ever_Program
{
    internal class XMLStageSetParser
    {
        public XMLStageSetParser()
        {
            
        }

        public void Parse(string aStageSetPath, List<IInteractable> interactableSet, Player aPlayer)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(aStageSetPath);
            foreach(XmlNode stageSetNode in doc.SelectNodes("StageTables//StageTable"){
                IInteractable currentAssignment;

                XmlNode AssignedInteractableNode = stageSetNode.SelectSingleNode("AssociatedInteractable");
                foreach(IInteractable Interactable in interactableSet)
                {
                    if (Interactable.GetNameString().Equals(AssignedInteractableNode.InnerText){
                        currentAssignment = Interactable;
                    }
                }  
                
                foreach(XmlNode stageElementNode in stageSetNode.SelectNodes(")
        }
    }
}