using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class Tile
    {
        #region Custom Types

        // Creating an enum type for tile types
        public enum Type { Hill = 0, Pasture = 1, Mountain = 2, Field = 3, Forest = 4, Desert = 5 }

        // Creating an enum type for tile resource types
        public enum ResourceType { Brick = 0, Wool = 1, Ore = 2, Grain = 3, Lumber = 4, Nothing = 5 }

        #endregion

        #region Fields

        public Type TileType { get; set; }
        public ResourceType TileProductType { get; set; }
        public byte TileNumber { get; set; }
        public byte TilePosition { get; set; }
        public Piece[] PieceAndCorner { get; set; }
        public Tile[] TileAndSide { get; set; }

        #endregion

        #region Constructor

        public Tile(Type tileType, byte tileNumber, byte tilePosition)
        {
            PieceAndCorner = new Piece[6];
            TileAndSide = new Tile[6];
            this.TileNumber = tileNumber;
            this.TilePosition = tilePosition;
            switch (tileType)
            {
                case Type.Desert:
                    this.TileType = Type.Desert;
                    this.TileProductType = ResourceType.Nothing;                    
                    break;
                case Type.Field:
                    this.TileType = Type.Field;
                    this.TileProductType = ResourceType.Grain;                    
                    break;
                case Type.Forest:
                    this.TileType = Type.Forest;
                    this.TileProductType = ResourceType.Lumber;                    
                    break;
                case Type.Hill:
                    this.TileType = Type.Hill;
                    this.TileProductType = ResourceType.Brick;                    
                    break;
                case Type.Mountain:
                    this.TileType = Type.Mountain;
                    this.TileProductType = ResourceType.Ore;                    
                    break;
                case Type.Pasture:
                    this.TileType = Type.Pasture;
                    this.TileProductType = ResourceType.Wool;                   
                    break;
                default:
                    Console.WriteLine("Please provide a tile type and its number");
                    break;
            }
        }

        #endregion
    }
}
