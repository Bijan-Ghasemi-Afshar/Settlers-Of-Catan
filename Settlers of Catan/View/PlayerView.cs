using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.View
{
    class PlayerView
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintNumberOfPlayers(byte numberOfPlayers)
        {
            Console.WriteLine("Number of players: " + numberOfPlayers);
        }

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

        public void PrintPlayerAdded(string name)
        {
            Console.WriteLine("Player " + name + " is added.");
        }

        public void AskForPlayerNumber()
        {
            Console.Write("Enter the number of players: ");
        }

        public void AskForPlayerName(byte playerNumber)
        {
            Console.Write("Enter the name of player " + playerNumber + ": ");
        }

        public void PrintReorderedPlayers(Player[] players)
        {
            Console.WriteLine("\nThis is the order of turns for players");
            foreach (Player player in players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
