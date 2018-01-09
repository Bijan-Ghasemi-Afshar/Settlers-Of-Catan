using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;
using Settlers_of_Catan.View;

namespace Settlers_of_Catan.Controller
{
    class BoardController
    {
        private Board Board;
        private BoardView BoardView;

        public BoardController()
        {
            Board = new Board();
            BoardView = new BoardView();
        }

        // Controller Methods
        public void CreateBoard()
        {            
            Random random = new Random();
            for (byte i=0; i<Board.NumberOfTiles; i++)
            {                
                byte RandomNumberTileType = (byte)random.Next(0, 5);
                byte RandomNumberTilePosition = (byte)random.Next(0, 19);
                byte RandomNumberTileNumber = (byte)random.Next(2, 13);

                Board.AddTileToBoard((Tile.Type)RandomNumberTileType, RandomNumberTileNumber, i);
            }            
        }        

        // Print Board
        public void PrintBoard()
        {
            BoardView.PrintMessage("Board:");
            BoardView.PrintBoard(Board.Tiles);
            BoardView.PrintMessage("\n");
        }
    }
}
