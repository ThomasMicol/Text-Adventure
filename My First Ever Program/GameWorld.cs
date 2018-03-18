using System;
using System.Collections.Generic;

namespace My_First_Ever_Program
{
    internal class GameWorld
    {
        private Player myPlayer;
        protected List<IEntity> myEntities = new List<IEntity>();
        protected BiomeLogger myBiomeLogger = new BiomeLogger();
        protected bool isRunning;

        public GameWorld(Player myPlayer)
        {
            this.myPlayer = myPlayer;
            myPlayer.SetSurroundings(myBiomeLogger.GetRandomBiome());
            this.isRunning = true;
        }

        public void Run()
        {
            Console.WriteLine("You open your eyes to the world around you.");
            while(this.isRunning == true)
            {
                Console.WriteLine(this.myPlayer.GetState());
                Console.WriteLine("What should your hero do?");
                string nextMove = Console.ReadLine();
                this.Update(nextMove);
            }
        }

        protected void Update(string aMove)
        {
            myPlayer.Interact(aMove);
            foreach(IEntity aEnt in this.myEntities)
            {
                aEnt.Update();
            }
        }
    }
}