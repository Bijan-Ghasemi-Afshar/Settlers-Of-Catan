using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Controller
{
    class BoardController
    {
        public Board Board;

        public BoardController()
        {
            Board = new Board();
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
            byte counter = 0;
            foreach (Tile tile in Board.Tiles)
            {
                Console.WriteLine("Tile Position: " + counter + " Tile Number: " + tile.TileNumber + " Tile Type: " + tile.TileType);
                counter++;
            }
        }
    }
}
