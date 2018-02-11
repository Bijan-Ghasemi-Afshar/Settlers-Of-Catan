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

        // Set Tile Adjacent Sides 
        public void SetAdjacentTiles(Tile tile, Tile[] tiles)
        {            

            byte innerCircleStart = 12, innerCircleEnd = 17;
            byte outterCircleStart = 0, outterCircleEnd = 11;
            byte center = 18;

            #region If this is the tile at the center
            if (tile.TilePosition == center)
            {
                byte tileSide = 0;
                for (byte i = innerCircleStart; i < center; i++)
                {
                    tile.TileAndSide[tileSide] = tiles[i];

                    byte otherTileSide = (byte)(tileSide + 3);
                    tiles[i].TileAndSide[otherTileSide % 6] = tile;

                    tileSide++;
                }
            }
            #endregion

                       
            #region If this is one of the tiles in the inner circle
            if (tile.TilePosition <= innerCircleEnd && tile.TilePosition >= innerCircleStart)
            {

                #region Setting outter circle tiles adjacent to this tile

                // Setting the starting side to associate with outter tiles (ani-clockwise)
                // If the tile is the first tile in the inner circle start setting the outter tiles connected to it from side number 6 - Needs some documentation about the procedure 
                byte sideConToOutterTile;
                if (tile.TilePosition == innerCircleStart)
                    sideConToOutterTile = 5;
                else
                    sideConToOutterTile = (byte)(tile.TilePosition - (innerCircleStart + 1));

                // Setting the starting outter tile associated to this tile (ani-clockwise) 
                byte outterTileConToTile;
                if (tile.TilePosition == innerCircleStart)
                    outterTileConToTile = outterCircleEnd;
                else
                    outterTileConToTile = (byte)(((tile.TilePosition - innerCircleStart) * 2) - 1);


                // Setting the adjacent tile (3 sides of inner circle tiles are adjacent to outter circle tiles)
                for (int i = 0; i < 3; i++)
                {

                    sideConToOutterTile = (byte)(sideConToOutterTile % 6);

                    outterTileConToTile = (byte)(outterTileConToTile % (outterCircleEnd + 1));

                    // If this side has been associated, skip to the next side
                    if (tile.TileAndSide[sideConToOutterTile] != null)
                    {
                        sideConToOutterTile++;
                        outterTileConToTile++;
                        continue;
                    }


                    tile.TileAndSide[sideConToOutterTile] = tiles[outterTileConToTile];
                    byte otherTileSide = (byte)(sideConToOutterTile + 3);
                    tiles[outterTileConToTile].TileAndSide[otherTileSide % 6] = tile;

                    sideConToOutterTile++;
                    outterTileConToTile++;
                }

                #endregion


                #region Setting inner circle tiles adjacent to this tile

                // Calculating the position of the next adjacent inner circle tile 
                byte nextAdjacentInnerTile = (byte)(((tile.TilePosition + 1) % 6) + innerCircleStart);

                // Calculating the side connected to the next adjacent inner circle tile & other tile's connected side
                byte sideConToInnerCircleTile = (byte)((tile.TilePosition + 2) % 6);
                byte otherTilesideConToThisTile = (byte)((sideConToInnerCircleTile + 3) % 6);

                tile.TileAndSide[sideConToInnerCircleTile] = tiles[nextAdjacentInnerTile];
                tiles[nextAdjacentInnerTile].TileAndSide[otherTilesideConToThisTile] = tile;

                #endregion

            }
            #endregion


            #region If this is one of the tiles in the outter circle
            if (tile.TilePosition >= outterCircleStart && tile.TilePosition <= outterCircleEnd)
            {
                // Local variables
                byte firstTileConSide = 2, sideConToOutterCircleTile, otherTilesideConToThisTile;

                // Calculating the position of the next adjacent outter circle tile 
                byte nextAdjacentOutterTile = (byte)((tile.TilePosition + 1) % 12);


                // Calculating the side connected to the next adjacent outter circle tile & other tile's connected side
                // If the tile is the first even or odd tile 
                if (tile.TilePosition == 0 || tile.TilePosition == 1)
                    sideConToOutterCircleTile = firstTileConSide;
                
                if ((tile.TilePosition % 2) == 0)
                    sideConToOutterCircleTile = (byte)(((tile.TilePosition / 2) + firstTileConSide) % 6);
                else
                    sideConToOutterCircleTile = (byte)((((tile.TilePosition - 1) / 2) + firstTileConSide) % 6);


                otherTilesideConToThisTile = (byte)((sideConToOutterCircleTile + 3) % 6);

                tile.TileAndSide[sideConToOutterCircleTile] = tiles[nextAdjacentOutterTile];
                tiles[nextAdjacentOutterTile].TileAndSide[otherTilesideConToThisTile] = tile;
            }
            #endregion

        }

        #endregion

    }
}
