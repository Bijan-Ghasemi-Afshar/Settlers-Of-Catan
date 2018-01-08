using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Controller
{
    class GameController
    {
        private PlayerController playerController;
        private BoardController boardController;
        private bool GameHasAWinner;
        private static short TotalTurns;

        public GameController()
        {
            playerController = new PlayerController();
            boardController = new BoardController();
            GameHasAWinner = false;
            TotalTurns = 0;
        }

        
        // Controller Methods
        
        // Initialiser
        public void Launcher()
        {
            Console.WriteLine("Creating the board");
            boardController.CreateBoard();
            boardController.PrintBoard();
            Console.WriteLine("Board Created.\n\n");

            playerController.AddPlayers();
            playerController.PrintThePlayers();
        }

        // Game Runner
        public void GameRunner()
        {
            do
            {

            } while (!GameHasAWinner);
        }

        // Rolling The Dice
        public byte RoleDice()
        {
            Random random = new Random();
            return (byte)random.Next(2, 13);
        }

        // Game Has a winner?
        public bool HasWinner()
        {
            return playerController.HasWinner();
        }
                
    }
}
