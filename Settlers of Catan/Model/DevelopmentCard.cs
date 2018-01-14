using System;
using System.Collections.Generic;
using System.Text;
using Settlers_of_Catan.Model;

namespace Settlers_of_Catan.Model
{
    class DevelopmentCard
    {

        #region Fields
        public string Descriptrion { get; }
        public Model.Tile.ResourceType[] ResourcesNeeded { get; }
        public byte VP { get; }
        #endregion

        #region Constructor
        public DevelopmentCard()
        {
            Descriptrion = "";
            ResourcesNeeded = new Tile.ResourceType[] { Tile.ResourceType.Wool, Tile.ResourceType.Ore, Tile.ResourceType.Grain };
            VP = 0;
        }
        #endregion


    }
}
