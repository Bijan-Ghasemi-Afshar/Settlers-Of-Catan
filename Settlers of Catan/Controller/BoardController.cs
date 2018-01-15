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
        }

        #endregion

        #region Controller Methods

        // Controller Methods
        public void CreateBoard()
        {
            Random random = new Random();
            Tile tileContainer;
            for (byte i = 0; i < Board.NumberOfTiles; i++)
            {
                byte RandomNumberTileType = (byte)random.Next(0, 5);
                byte RandomNumberTilePosition = (byte)random.Next(0, 19);
                byte RandomNumberTileNumber = (byte)random.Next(2, 13);

                tileContainer = _tileController.CreateTile((Tile.Type)RandomNumberTileType, RandomNumberTileNumber, i);
                AddTileToBoard(tileContainer, RandomNumberTilePosition);                
            }
            
        }

        // Add Tile To Board
        public void AddTileToBoard(Tile tile, byte tilePosition)
        {
            _board.Tiles[tilePosition] = tile;
            _tileController.SetAdjacentTiles(tile);
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
