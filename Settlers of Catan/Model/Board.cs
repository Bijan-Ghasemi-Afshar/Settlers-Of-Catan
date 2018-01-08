using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Board
    {
        public Tile[] Tiles { get; set; }
        public const byte NumberOfTiles = 19;

        public Board()
        {
            Tiles = new Tile[NumberOfTiles];
        }

        // Methods
        public void AddTileToBoard(Tile.Type tileType, byte tileNumber, byte tilePosition)
        {
            Tiles[tilePosition] = new Tile(tileType, tileNumber);
        }
    }
}
