using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.View
{
    class BoardView
    {

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintBoard(Tile[] tiles)
        {            
            byte counter = 0;
            foreach (Tile tile in tiles)
            {
                Console.WriteLine("Tile Position: " + counter + " Tile Number: " + tile.TileNumber + " Tile Type: " + tile.TileType);
                counter++;
            }
        }        

        // For testing purposes
        public void PrintTileAdjacentTiles(Tile tile)
        {
            Console.WriteLine("\nTile Number: " + tile.TilePosition + " adjacent tiles");
            for (int i=0; i<tile.TileAndSide.Length; i++)
            {
                Console.WriteLine("Side: " + i + "    Tile Position: " + tile.TileAndSide[i].TilePosition + "    Tile Type: " + tile.TileAndSide[i].TileType);
            }
        }
    }
}
