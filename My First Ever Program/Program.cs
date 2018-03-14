using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Ever_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name Wary Traveller");
            Player myPLayer = new Player(Console.ReadLine());
            new GameWorld(myPLayer).Run();
        }
    }
}
