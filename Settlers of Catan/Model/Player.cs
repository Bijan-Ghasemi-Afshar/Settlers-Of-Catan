using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Player
    {
        #region Fields

        public string Name { get; set; }
        public PiecePack PackOfPiece { get; set; }
        public byte Points { get; set; }
        public byte Brick { get; set; }
        public byte Wool { get; set; }
        public byte Ore { get; set; }
        public byte Grain { get; set; }
        public byte Lumber { get; set; }
        public byte Nothing { get; set; }

        #endregion

        #region Constructor

        public Player(string name)
        {
            this.Name = name;
            PackOfPiece = new PiecePack();
        }

        #endregion
    }
}
