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
            new XMLStageSetParser().Parse(myBiome.GetStageSetPath(), myInteractables, myPlayer);
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
                Console.WriteLine("The Biome " + myBiome.GetName() + " couldnt get its interactables and as such cannot be used as a biome\nEither restore the default sets by reinstalling or make your new sets in the resource file.\nThis window will now close");
                Console.ReadKey();
                throw new ArgumentOutOfRangeException(""); 
            }

        }
    }
}