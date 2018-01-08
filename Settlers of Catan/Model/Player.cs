using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Player
    {
        public string Name { get; set; }
        public PiecePack PackOfPiece { get; set; }
        public byte Points { get; set; }

        public Player(string name)
        {
            this.Name = name;
            PackOfPiece = new PiecePack();
        }
    }
}
