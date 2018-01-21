using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Controller
{
    class TileController
    {        

        #region Controller Methods

        // Create Tile
        public Tile CreateTile(Tile.Type tileType, byte tileNumber, byte tilePosition)
        {
            return new Tile(tileType, tileNumber, tilePosition); 
        }

        // Set Tile Adjacent Sides 
        public void SetAdjacentTiles(Tile tile, Tile[] tiles)
        {
            // To be continued...

            // If this is the tile at the center
            if (tile.TilePosition == 18)
            {
                byte tileSide = 0;
                for(byte i=12; i<18; i++)
                {
                    tile.TileAndSide[tileSide] = tiles[i];
                    tileSide++;
                }
            }

            // If this is not the tile at the center...

        }

        #endregion

    }
}
