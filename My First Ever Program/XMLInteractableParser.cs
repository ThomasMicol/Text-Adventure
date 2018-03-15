using System;
using System.Collections.Generic;
using System.Xml;

namespace My_First_Ever_Program
{
    internal class XMLInteractableParser
    {
        public XMLInteractableParser()
        {
        }
        
        public void Parse(List<IInteractable> InteractableList)
        {
            XmlDocument InteractableDoc = new XmlDocument();
            InteractableDoc.Load("interactables.xml");
            foreach(XmlNode node in InteractableDoc.SelectNodes("interactables//interactable"))
            {
                XmlNode aNode = node.SelectSingleNode("Name");
                string Name = aNode.InnerText;
                aNode = aNode.NextSibling;
                string DiscoveredString = aNode.InnerText;
                IInteractable aInteractable = new InteractableTemplate(Name, DiscoveredString);
                InteractableList.Add(aInteractable);

            }


        }
    }
}