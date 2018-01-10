using System;
using System.Collections.Generic;
using System.Text;

namespace Settlers_of_Catan.View
{
    class GameView
    {

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintTurn(int totalTurns, string name)
        {
            Console.WriteLine("_________________" + "Turn: " + totalTurns + "_________________");
            Console.WriteLine( name + "'s turn to play");
        }

        public void AskForPlayerMove()
        {
            Console.WriteLine("Would you like to make a move?");
        }

    }
}
