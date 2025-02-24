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
    public abstract class FirstReward
    {
        public required string reward_name;
        public required string reward_id;

        public override string ToString() => reward_name;
    }

    public class PlantUnlock : FirstReward
    {
        public required string unlockID = "Plant";
        public required Plant plant { get; set; }
    }

    #endregion

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
        public List<string>? aliases { get; set; }
        public string? objclass { get; set; }
        public ObjData? objdata { get; set; }
    }
    public class LaneGrid
    {
        [JsonPropertyName("X")]
        public int x { get; set; }

        [JsonPropertyName("Y")]
        public int y { get; set; }
    }
    public class DynamicZombie
    {
        [JsonPropertyName("PointIncrementPerWave")]
        public int pointIncrementPerWave { get; set; }

        [JsonPropertyName("StartingPoints")]
        public int startingPoints { get; set; }

        [JsonPropertyName("StartingWave")]
        public int startingWave { get; set; }

        [JsonPropertyName("ZombiePool")]
        public List<string> zombiePool { get; set; }
    }
    public class Zombie
    {
        [JsonPropertyName("Row")]
        public string row { get; set; }

        [JsonPropertyName("Type")]
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

    public class ObjDataConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ObjData);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            string? objclass = (string)jsonObject["objclass"];

            ObjData objdata;
            switch (objclass)
            {
                case "LevelDefinition":
                    objdata = new LevelDefinition();
                    break;
                case "MausoleumLaneProperties":
                    objdata = new MausoleumLaneProperties();
                    break;
                case "SeedBankProperties":
                    objdata = new SeedBankProperties();
                    break;
                case "WaveManagerModuleProperties":
                    objdata = new WaveManagerModuleProperties();
                    break;
                case "WaveManagerProperties":
                    objdata = new WaveManagerProperties();
                    break;
                default:
                    throw new NotImplementedException($"Unknown objclass: {objclass}");
            }

            serializer.Populate(jsonObject["objdata"].CreateReader(), objdata);
            return objdata;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
