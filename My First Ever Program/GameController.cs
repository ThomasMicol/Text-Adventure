using System;

namespace My_First_Ever_Program
{
    internal class GameController
    {
        protected XMLInteractableParser interactableParser = new XMLInteractableParser();
        protected GameWorld myWorld;
        protected Player myPlayer;

        public void LaunchGame()
        {
            Console.WriteLine("What is your name weary traveller?");
            myPlayer = new Player(Console.ReadLine());
            myWorld = new GameWorld(myPlayer);
            myWorld.Run();
        }
    }
}