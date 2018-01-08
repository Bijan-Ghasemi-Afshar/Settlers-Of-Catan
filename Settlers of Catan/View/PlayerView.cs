using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.View
{
    class PlayerView
    {

        public void PrintPlayers(Player[] players)
        {
            Console.WriteLine("\n\nThese are the players: ");
            foreach (Player player in players)
            {
                Console.WriteLine("player: " + player.Name);
                Console.WriteLine("Road: " + player.PackOfPiece.Road.NumberOfPieces);
                Console.WriteLine("Settlement: " + player.PackOfPiece.Settlement.NumberOfPieces);
                Console.WriteLine("City: " + player.PackOfPiece.City.NumberOfPieces);
            }
        }

    }
}
