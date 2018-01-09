using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class GameController
    {
        private PlayerController playerController;
        private BoardController boardController;
        private BoardView boardView;
        private GameView gameView;
        private bool GameHasAWinner;
        private static short TotalTurns;

        public GameController()
        {
            playerController = new PlayerController();
            boardController = new BoardController();
            boardView = new BoardView();
            gameView = new GameView();
            GameHasAWinner = false;
            TotalTurns = 0;
        }

        
        // Controller Methods
        
        // Initialiser
        public void Launcher()
        {            
            // Creating the board
            boardController.CreateBoard();
            boardController.PrintBoard();                     

            // Adding the players
            playerController.AddPlayers();
            playerController.PrintPlayers();

            // Reorder players
            playerController.ReorderPlayers();

            // Run the game
            GameRunner();
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
