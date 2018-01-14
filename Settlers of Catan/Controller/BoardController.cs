using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class BoardController
    {
        private Board _board;
        private BoardView _boardView;

        public BoardController()
        {
            _board = new Board();
            _boardView = new BoardView();
        }

        // Controller Methods
        public void CreateBoard()
        {            
            Random random = new Random();
            for (byte i=0; i< Board.NumberOfTiles; i++)
            {                
                byte RandomNumberTileType = (byte)random.Next(0, 5);
                byte RandomNumberTilePosition = (byte)random.Next(0, 19);
                byte RandomNumberTileNumber = (byte)random.Next(2, 13);

                _board.AddTileToBoard((Tile.Type)RandomNumberTileType, RandomNumberTileNumber, i);
            }            
        }        

        // Print Board
        public void PrintBoard()
        {
            _boardView.PrintMessage("Board:");
            _boardView.PrintBoard(_board.Tiles);
            _boardView.PrintMessage("\n");
        }
    }
}
