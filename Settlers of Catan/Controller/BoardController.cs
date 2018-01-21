using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class BoardController
    {
        #region Fields

        private Board _board;
        private BoardView _boardView;
        private TileController _tileController;

        #endregion

        #region Constructor

        public BoardController()
        {
            _board = new Board();
            _boardView = new BoardView();
            _tileController = new TileController();
        }

        #endregion

        #region Controller Methods

        // Controller Methods
        public void CreateBoard()
        {
            Random random = new Random();
            Tile tileContainer;
            for (byte tilePos = 0; tilePos < Board.NumberOfTiles; tilePos++)
            {
                byte RandomNumberTileType = (byte)random.Next(0, 5);                
                byte RandomNumberTileNumber = (byte)random.Next(2, 13);

                tileContainer = _tileController.CreateTile((Tile.Type)RandomNumberTileType, RandomNumberTileNumber, tilePos);               
                AddTileToBoard(tileContainer, tilePos);                
            }
            
        }

        // Add Tile To Board
        public void AddTileToBoard(Tile tile, byte tilePosition)
        {
            _board.Tiles[tilePosition] = tile;            
        }

        // Get Tile from Board
        public Tile GetTileFromBoard(byte position)
        {
            return _board.Tiles[position];
        }

        // Set Tiles Adjacent to each other 
        public void SetTileConnection()
        {
            // To be continued...
            for (int i= (Board.NumberOfTiles-1); i>=0; i--)
            {
                _tileController.SetAdjacentTiles(_board.Tiles[i], _board.Tiles);
                Console.WriteLine(i + " Set Adjacent Tiles was called");                
            }
            // The Below has to be REMOVED or CHANGED
            _boardView.PrintTileAdjacentTiles(_board.Tiles[18]);

        }

        // Print Board
        public void PrintBoard()
        {
            _boardView.PrintMessage("Board:");
            _boardView.PrintBoard(_board.Tiles);
            _boardView.PrintMessage("\n");
        }

        #endregion
    }
}
