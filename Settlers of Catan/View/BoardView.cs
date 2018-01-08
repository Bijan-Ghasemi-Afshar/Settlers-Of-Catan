using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.View
{
    class BoardView
    {

        public void PrintBoard(Tile[] tiles)
        {
            byte counter = 0;
            foreach (Tile tile in tiles)
            {
                Console.WriteLine("Tile Position: " + counter + " Tile Number: " + tile.TileNumber + " Tile Type: " + tile.TileType);
                counter++;
            }
        }

    }
}
