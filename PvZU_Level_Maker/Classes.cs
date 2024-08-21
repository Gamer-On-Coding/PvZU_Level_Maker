using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PvZU_Level_Maker
{
    public class Level
    {
        [JsonPropertyName("#comment")]
        public required string comment;

        public List<GameObject> objects = [];
        public int version = 1;
    }

    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class GameObject
    {
        public List<string> aliases { get; set; }
        public string objclass { get; set; }
        public ObjData objdata { get; set; }
    }

    public class ObjDataConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ObjData);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var objclass = (string)jsonObject["objclass"];

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

    public class World
    {
        public required string world_name;
        public required string world_id;
        public string world_description;

        public override string ToString() => world_name;
    }

    public class FirstRewardType
    {
        public required string reward_name;
        public required string reward_id;
        public string reward_type;

        public override string ToString() => reward_name;
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

}
