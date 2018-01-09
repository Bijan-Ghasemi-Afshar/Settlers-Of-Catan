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
                PlayerView.AskForPlayerNumber();
                try
                {
                    NumberOfPlayers = Byte.Parse(Console.ReadLine());

                    if (NumberOfPlayers == 0 || !(NumberOfPlayers.GetType().Equals(NumberOfPlayers.GetType())))
                        PlayerView.PrintMessage("Please enter a positive number");                        

                }
                catch (Exception e)
                {
                    PlayerView.PrintMessage("Please enter a positive number");
                }

            } while (NumberOfPlayers <= 0);

            // Setting the number of players
            SetNumberOfPlayers(NumberOfPlayers);
            PlayerView.PrintNumberOfPlayers(NumberOfPlayers);
            

            // Getting the name of the players and setting the players
            string NameOfThePlayer = null;
            for (byte i = 0; i < NumberOfPlayers; i++)
            {
                do
                {

                    PlayerView.AskForPlayerName((byte)(i+1));
                    try
                    {
                        NameOfThePlayer = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        PlayerView.AskForPlayerName((byte)(i + 1));
                    }

                    // Adding the player to the game
                    CreatePlayer(NameOfThePlayer, i);
                    PlayerView.PrintPlayerAdded(NameOfThePlayer);

                } while (NumberOfPlayers <= 0);
            }
        }

        // Reorder Players
        public void ReorderPlayers()
        {
            // Need to be written
            //byte max = 0;
            //Random random = new Random();
            //for(byte i=0; i<Players.Length; i++)
            //{
            //    for (byte j=(byte)(Players.Length-i); j>=0; j--)
            //    {
            //        if (random.Next(2, 13) > max)
            //            max = j;
            //    }
            //}
        }

        // Printing Players
        public void PrintPlayers()
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
