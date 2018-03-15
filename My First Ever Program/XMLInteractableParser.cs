using System;
using System.Collections.Generic;
using System.Xml;

namespace My_First_Ever_Program
{
    internal class XMLInteractableParser
    {
        
        public void Parse(List<IInteractable> InteractableList, Player aPlayer)
        {
            XmlDocument InteractableDoc = new XmlDocument();
            InteractableDoc.Load("interactables.xml");
            foreach(XmlNode node in InteractableDoc.SelectNodes("interactables//interactable"))
            {
                XmlNode aNode = node.SelectSingleNode("Name");
                string Name = aNode.InnerText;
                aNode = aNode.NextSibling;
                string DiscoveredString = aNode.InnerText;
                IInteractable aInteractable = new InteractableTemplate(aPlayer, Name, DiscoveredString);
                foreach (XmlNode interaction in node.SelectNodes("InteractionTable//Interaction"))
                {
                    XmlNode aInteractionNode = interaction.SelectSingleNode("InteractionKey");
                    string key = aInteractionNode.InnerText;
                    string descriptor = aInteractionNode.NextSibling.InnerText;
                    string action = aInteractionNode.NextSibling.NextSibling.InnerText;
                    string[] ActionableArray = new string[2]{descriptor, action};
                    aInteractable.AddInteraction(key, ActionableArray);
                }
                InteractableList.Add(aInteractable);

            }


        }
    }
}