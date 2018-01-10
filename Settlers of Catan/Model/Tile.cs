﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Settlers_of_Catan.Model
{
    class Tile
    {
        // Creating an enum type for tile types
        public enum Type { Hill=0, Pasture=1, Mountain=2, Field=3, Forest=4, Desert=5 }

        // Creating an enum type for tile resource types
        public enum ResourceType { Brick=0, Wool=1, Ore=2, Grain=3, Lumber=4, Nothing=5 }


        public Type TileType { get; set; }
        public ResourceType TileProductType { get; set; }
        public byte TileNumber { get; set; }


        public Tile(Type tileType, byte tileNumber)
        {
            switch (tileType)
            {
                case Type.Desert:
                    this.TileType = Type.Desert;
                    this.TileProductType = ResourceType.Nothing;
                    this.TileNumber = tileNumber;
                    break;
                case Type.Field:
                    this.TileType = Type.Field;
                    this.TileProductType = ResourceType.Grain;
                    this.TileNumber = tileNumber;
                    break;
                case Type.Forest:
                    this.TileType = Type.Forest;
                    this.TileProductType = ResourceType.Lumber;
                    this.TileNumber = tileNumber;
                    break;
                case Type.Hill:
                    this.TileType = Type.Hill;
                    this.TileProductType = ResourceType.Brick;
                    this.TileNumber = tileNumber;
                    break;
                case Type.Mountain:
                    this.TileType = Type.Mountain;
                    this.TileProductType = ResourceType.Ore;
                    this.TileNumber = tileNumber;
                    break;
                case Type.Pasture:
                    this.TileType = Type.Pasture;
                    this.TileProductType = ResourceType.Wool;
                    this.TileNumber = tileNumber;
                    break;
                default:
                    Console.WriteLine("Please provide a tile type and its number");
                    break;
            }
        }
    }
}
