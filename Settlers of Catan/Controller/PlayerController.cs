using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class PlayerController
    {
        private Player[] Players;
        private PlayerView PlayerView;

        
        public PlayerController()
        {
            PlayerView = new PlayerView();
        }


        // Controller methods
        public void SetNumberOfPlayers(byte numberOfPlayers)
        {
            Players = new Player[numberOfPlayers];
        }

        public void CreatePlayer(string playerName, byte index)
        {
            Players.SetValue(new Player(playerName), (int)index);
        }

        // Adding Players
        public void AddPlayers()
        {
            // Getting the number of players
            byte NumberOfPlayers = 0;
            do
            {
                Console.Write("Enter the number of players: ");
                try
                {
                    NumberOfPlayers = Byte.Parse(Console.ReadLine());

                    if (NumberOfPlayers == 0 || !(NumberOfPlayers.GetType().Equals(NumberOfPlayers.GetType())))
                        Console.WriteLine("Please enter a positive number");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a positive number");
                }

            } while (NumberOfPlayers <= 0);

            // Setting the number of players
            SetNumberOfPlayers(NumberOfPlayers);
            Console.WriteLine("Number of players: " + NumberOfPlayers);

            // Getting the name of the players
            string NameOfThePlayer = null;
            for (byte i = 0; i < NumberOfPlayers; i++)
            {
                do
                {
                    Console.Write("Enter the name of player " + (i + 1) + ": ");
                    try
                    {
                        NameOfThePlayer = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.Write(e + "\nEnter the name of player " + (i + 1) + ": ");
                    }

                    // Adding the player to the game
                    CreatePlayer(NameOfThePlayer, i);
                    Console.WriteLine("Player " + NameOfThePlayer + " is added.");
                } while (NumberOfPlayers <= 0);
            }
        }

        // Printing Players
        public void PrintThePlayers()
        {

            PlayerView.PrintPlayers(Players);
        }

        // Is there a winner player
        public bool HasWinner()
        {
            foreach(Player player in Players)
            {
                if (player.Points >= 10)
                    return true;
            }

            return false;
        }
    }
}
