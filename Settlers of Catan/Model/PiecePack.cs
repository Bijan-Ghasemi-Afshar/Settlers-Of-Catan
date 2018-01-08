using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class PiecePack
    {
        public Piece Road { get; }
        public Piece Settlement { get; }
        public Piece City { get; }

        public PiecePack()
        {
            Road = new Piece(Piece.Type.Road);
            Settlement = new Piece(Piece.Type.Settlement);
            City = new Piece(Piece.Type.City);
        }
    }
}
