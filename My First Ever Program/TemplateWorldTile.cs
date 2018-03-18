using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class TemplateWorldTile : IWorldTile
    {
        protected Player myPlayer;
        protected IBiome myBiome;
        protected List<IInteractable> myInteractables = new List<IInteractable>();

        public TemplateWorldTile(Player player, IBiome aBiome)
        {
            this.myPlayer = player;
            this.myBiome = aBiome;
            new XMLInteractableParser().Parse(myBiome.GetResourceSetPath(), myInteractables, myPlayer);
        }

        public IBiome GetBiome()
        {
            return myBiome;
        }

        public string GetDesciption()
        {
            return myBiome.GetDescriptor();
        }

        public IInteractable GetInteractable()
        {
            Random rnd = new Random();
            int accession = rnd.Next(0, myInteractables.Count);
            try
            {
                return myInteractables[accession];
            }catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The Biome " + myBiome.GetName() + " couldnt get its interactables and as such cannot be used as a biome");
                throw new ArgumentOutOfRangeException("The Biome " + myBiome.GetName() + " couldnt get its interactables and as such cannot be used as a biome"); 
            }

        }
    }
}