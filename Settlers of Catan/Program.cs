using System;
using Settlers_of_Catan.Controller;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Creating a Game Controller
            GameController gameController = new GameController();
            gameController.Launcher();


            Console.ReadKey();
        }
    }
}