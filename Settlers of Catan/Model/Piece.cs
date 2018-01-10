using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Piece
    {
        #region Custom Types
        // Creating an enum type for Piece type
        public enum Type { Road = 0, Settlement = 1, City = 2 }
        #endregion

        #region Fields
        public Type PieceType { get; }
        public byte NumberOfPieces { get; }
        public byte VP { get; }
        public Model.Tile.ResourceType[] ResourcesNeeded { get; }
        #endregion

        #region Constructor
        public Piece(Type type)
        {
            switch (type)
            {
                case Type.Road:
                    PieceType = Type.Road;
                    NumberOfPieces = 15;
                    VP = 0;
                    ResourcesNeeded = new Tile.ResourceType[] { Tile.ResourceType.Brick, Tile.ResourceType.Lumber };
                    break;
                case Type.Settlement:
                    PieceType = Type.Settlement;
                    NumberOfPieces = 5;
                    VP = 1;
                    ResourcesNeeded = new Tile.ResourceType[] { Tile.ResourceType.Brick, Tile.ResourceType.Lumber, Tile.ResourceType.Wool, Tile.ResourceType.Grain };
                    break;
                case Type.City:
                    PieceType = Type.City;
                    NumberOfPieces = 4;
                    VP = 2; ;
                    ResourcesNeeded = new Tile.ResourceType[] { Tile.ResourceType.Grain, Tile.ResourceType.Grain, Tile.ResourceType.Ore, Tile.ResourceType.Ore, Tile.ResourceType.Ore };
                    break;
                default:
                    Console.WriteLine("Please provide a piece type to make a piece");
                    break;
            }
        }
        #endregion
    }
}
