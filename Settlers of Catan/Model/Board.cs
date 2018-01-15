using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Board
    {
        #region Fields

        public Tile[] Tiles { get; set; }
        public const byte NumberOfTiles = 19;

        #endregion

        #region Constructor

        public Board()
        {
            Tiles = new Tile[NumberOfTiles];
        }

        #endregion        
    }
}
