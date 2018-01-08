using System;
using System.Collections.Generic;
using System.Text;

namespace Settlers_of_Catan.Model
{
    class Piece
    {
        // Creating an enum type for Piece type
        public enum Type { Road=0, Settlement=1, City=2 }

        public Type PieceType { get; }
        public byte NumberOfPieces { get; }
        public byte VP { get; }

        public Piece(Type type)
        {
            switch (type)
            {
                case Type.Road:
                    PieceType = Type.Road;
                    NumberOfPieces = 15;
                    VP = 0;
                    break;
                case Type.Settlement:
                    PieceType = Type.Settlement;
                    NumberOfPieces = 5;
                    VP = 1;
                    break;
                case Type.City:
                    PieceType = Type.City;
                    NumberOfPieces = 4;
                    VP = 2; ;
                    break;
                default:
                    Console.WriteLine("Please provide a piece type to make a piece");
                    break;
            }
        }
    }
}
