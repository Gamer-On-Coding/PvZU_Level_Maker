using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PvZU_Level_Maker
{
    #region firstreward
    public class FirstReward
    {
        public RewardType rewardType;
        public string reward;

        public static implicit operator string(FirstReward v)
        {
            throw new NotImplementedException();
        }


    }

    public class RewardType
    {
        public string typeName;
        public string typeID;

        public override string ToString()
        {
            return typeName;
        }
    }
    #endregion

    #region loot
    public class Loot
    {
        public string LootName;
        public string LootID;

        public override string ToString()
        {
            return LootName;
        }
    }
    #endregion

    #region portal
    public class PortalType
    {
        public string name;
        public string id;

        public override string ToString() => name;
    }
    #endregion

    public class SpawnEffect
    {
        public string name;
        public string effectID;

        public override string ToString() => name;
    }

    public class SpawnSound
    {
        public string name;
        public string soundID;

        public override string ToString() => name;
    }

    public class WaveManagerProps
    {
        public string name;
        public string id;

        public override string ToString() => name;
    }

    #region json structure
    public class Level
    {
        [JsonProperty("#comment")]
        public string? comment;

        public List<GameObject> objects = [];
        public int version = 1;
    }
    public class GameObject
    {
        [JsonProperty("aliases")]
        public List<string>? aliases { get; set; }

        [JsonProperty("objclass")]
        public string objclass { get; set; }

        [JsonProperty("objdata")]
        [Newtonsoft.Json.JsonConverter(typeof(ObjDataConverter))]
        public ObjData objdata { get; set; }
    }

    public class LaneGrid
    {
        [JsonProperty("X")]
        public int x { get; set; }

        [JsonProperty("Y")]
        public int y { get; set; }
    }
    public class DynamicZombie
    {
        [JsonProperty("StartingWave")]
        public int startingWave { get; set; }

        [JsonProperty("StartingPoints")]
        public int startingPoints { get; set; }

        [JsonProperty("PointIncrementPerWave")]
        public int pointIncrementPerWave { get; set; }

        [JsonProperty("ZombiePool")]
        public List<string> zombiePool { get; set; }
    }
    public class Zombie
    {
        [JsonProperty("Row")]
        public string row { get; set; }

        [JsonProperty("Type")]
        public string type { get; set; }
    }
    #endregion

    #region UI structure
    public class World
    {
        public required string world_name;
        public required string world_id;
        public string? world_description;
        public string? comment_name;
        public string? level_name_format;

        public override string ToString() => world_name;
    }
    public class StageModule
    {
        public required string name { get; set; }
        public required string id { get; set; }

        public override string ToString() => name;
    }
    public class Module
    {
        public required string module_name;
        public required string module_id;

        public override string ToString() => module_name;
        public string ToID() => module_id;
    }
    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    #endregion
}
