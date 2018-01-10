using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class PlayerController
    {
        #region Fields
        private Player[] Players;
        private PlayerView PlayerView;
        #endregion

        #region Constructor
        public PlayerController()
        {
            PlayerView = new PlayerView();
        }
        #endregion

        #region Controller Methods
        // Set Number of Players
        public void SetNumberOfPlayers(byte numberOfPlayers)
        {
            Players = new Player[numberOfPlayers];
        }

        // Create Player
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

                    PlayerView.AskForPlayerName((byte)(i + 1));
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
            // Algorithm to randomise players based on a value given by throwing a dice            
            byte max = 0, position = 0;
            Random random = new Random();
            for (byte i = 0; i < Players.Length; i++)
            {
                for (int j = (Players.Length - 1); j >= 0; j--)
                {
                    // Like throwing a dice to see who gets the highest to reorder players
                    byte randomNumber = (byte)random.Next(2, 13);
                    if (randomNumber > max)
                    {
                        max = randomNumber;
                        position = (byte)j;
                    }
                }
                Player container = Players[i];
                Players[i] = Players[position];
                Players[position] = container;
            }

            // Printing reordered players
            PlayerView.PrintReorderedPlayers(Players);
        }

        // Printing Players
        public void PrintPlayers()
        {

            PlayerView.PrintPlayers(Players);
        }

        // Is there a winner player
        public bool HasWinner()
        {
            foreach (Player player in Players)
            {
                if (player.Points >= 10)
                    return true;
            }

            return false;
        }

        // Get Player who has to play this turn
        public string GetPlayerToPlay(int totalTurn)
        {
            int x = totalTurn % Players.Length;
            if (x == 0)
                return Players[Players.Length - 1].Name;

            return Players[x-1].Name;
        }
        #endregion        
    }
}
