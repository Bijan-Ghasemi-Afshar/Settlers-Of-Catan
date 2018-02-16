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
            boardController.SetTileConnection();

            // Adding the players
            playerController.AddPlayers();
            playerController.PrintPlayers();

            // Reorder players
            playerController.ReorderPlayers();

            // Set up game
            GameSetup();

            // Run the game
            GameRunner();
        }

        // Game Set up
        public void GameSetup()
        {            
            // Ask from the first player to last
            for (int i=0; i<playerController.NumberOfPlayers; i++)
            {
                gameView.AskToPlacePieceInitially(playerController.GetPlayerName((byte)i));
                // Get players input 
                try
                {
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // Ask from the last player to first
            for (int i=playerController.NumberOfPlayers - 1; i>=0; i--)
            {
                gameView.AskToPlacePieceInitially(playerController.GetPlayerName((byte)i));
                // Get players input 
                try
                {
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Game Runner
        public void GameRunner()
        {
            do
            {
                // Counter
                TotalTurns++;                                               

                // Each normal turn                
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
