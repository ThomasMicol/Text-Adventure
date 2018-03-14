using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class ForestWorldTile : IWorldTile
    {
        protected string BiomeDescriptor;
        protected Biomes myBiome;
        protected List<IInteractable> myInteractables = new List<IInteractable>();

        public ForestWorldTile()
        {
            myBiome = Biomes.Forest;
            BiomeDescriptor = "Rolling hills, green pastures and trees as far as the eye can see. \n If only this was the final destination of your journey";
            myInteractables.Add(new Cave());
            myInteractables.Add(new Shack());
        }

        public IInteractable GetInteractable()
        {
            Random rnd = new Random();
            int accession = rnd.Next(0, myInteractables.Count);
            return myInteractables[accession];
        }

        public Biomes GetBiome()
        {
            return this.myBiome;
        }

        public string GetDesciption()
        {
            return this.BiomeDescriptor;
        }
    }
}