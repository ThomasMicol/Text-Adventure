using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class ForestWorldTile : IWorldTile
    {
        protected Player myPlayer;
        protected string BiomeDescriptor;
        protected Biome myBiome;
        protected List<IInteractable> myInteractables = new List<IInteractable>();

        public ForestWorldTile(Player aPlayer, Biome aBiome)
        {
            myPlayer = aPlayer;
            myBiome = aBiome;
            BiomeDescriptor = "Rolling hills, green pastures and trees as far as the eye can see. \n If only this was the final destination of your journey";
            new XMLInteractableParser().Parse(myBiome.GetResourceSetPath(), myInteractables, myPlayer);
        }

        public IInteractable GetInteractable()
        {
            Random rnd = new Random();
            int accession = rnd.Next(0, myInteractables.Count);
            return myInteractables[accession];
        }

        public IBiome GetBiome()
        {
            return this.myBiome;
        }

        public string GetDesciption()
        {
            return this.myBiome.GetDescriptor();
        }
    }
}