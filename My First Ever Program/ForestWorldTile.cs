using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class ForestWorldTile : IWorldTile
    {
        protected Player myPlayer;
        protected string BiomeDescriptor;
        protected Biomes myBiome;
        protected List<IInteractable> myInteractables = new List<IInteractable>();

        public ForestWorldTile(Player aPlayer)
        {
            myPlayer = aPlayer;
            myBiome = Biomes.Forest;
            BiomeDescriptor = "Rolling hills, green pastures and trees as far as the eye can see. \n If only this was the final destination of your journey";
            new XMLInteractableParser().Parse(myInteractables, myPlayer);
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