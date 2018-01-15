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

        // Set Tile Adjacent Corners 
        public void SetAdjacentTiles(Tile tile)
        {
            // To be written
        }

        #endregion
    }
}
