using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class GameController
    {
        #region Fields
        private PlayerController playerController;
        private BoardController boardController;
        private BoardView boardView;
        private GameView gameView;        
        private static int TotalTurns;
        #endregion

        #region Constructor
        public GameController()
        {
            playerController = new PlayerController();
            boardController = new BoardController();
            boardView = new BoardView();
            gameView = new GameView();            
            TotalTurns = 0;
        }
        #endregion

        #region Controller Methods

        // Game Launcher
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

                TotalTurns++;
                gameView.PrintTurn(TotalTurns, PlayerToPlay(TotalTurns));
                gameView.AskForPlayerMove();
                // Get players input 
                try
                {
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            } while (!HasWinner());
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

        // Get player who has to play this turn
        public string PlayerToPlay(int totalTurn)
        {
            return playerController.GetPlayerToPlay(totalTurn);
        }

        #endregion
    }
}
