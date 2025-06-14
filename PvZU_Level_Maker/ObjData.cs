using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PvZU_Level_Maker
{
    public abstract class ObjData
    {
    }

    public class LevelDefinition : ObjData
    {
        [JsonProperty("CurrencyAmount")]
        public int currencyAmount { get; set; }

        [JsonProperty("Description")]
        public string description { get; set; }

        [JsonProperty("FirstIntroNarrative")]
        public string firstIntroNarrative { get; set; }

        [JsonProperty("FirstRewardParam")]
        public string firstRewardParam { get; set; }

        [JsonProperty("FirstRewardType")]
        public string firstRewardType { get; set; }

        [JsonProperty("LevelNumber")]
        public int levelNumber { get; set; }

        [JsonProperty("Loot")]
        public string loot { get; set; }

        [JsonProperty("Modules")]
        public List<string> modules { get; set; }

        [JsonProperty("Name")]
        public string name { get; set; }

        [JsonProperty("NormalPresentTable")]
        public string normalPresentTable { get; set; }

        [JsonProperty("ShinyPresentTable")]
        public string shinyPresentTable { get; set; }

        [JsonProperty("StageModule")]
        public string stageModule { get; set; }
    }

    public class MausoleumLaneProperties : ObjData
    {
        [JsonProperty("LaneGrids")]
        public List<LaneGrid> laneGrids { get; set; }
    }

    public class SeedBankProperties : ObjData
    {
        [JsonProperty("PlantBlackList")]
        public List<string> plantBlackList { get; set; }

        [JsonProperty("SelectionMethod")]
        public string selectionMethod { get; set; }
    }

    public class WaveManagerProperties : ObjData
    {
        [JsonProperty("FlagWaveInterval")]
        public int flagWaveInterval { get; set; }

        [JsonProperty("WaveCount")]
        public int waveCount { get; set; }

        [JsonProperty("Waves")]
        public List<List<string>> waves { get; set; }

        //[JsonProperty("WaveSpendingPointIncrement")]
        //public int waveSpendingPointIncrement { get; set; }

        //[JsonProperty("WaveSpendingPoints")]
        //public int waveSpendingPoints { get; set; }
    }

    public class SpawnZombiesJitteredWaveActionProps : ObjData
    {
        [JsonProperty("AdditionalPlantfood")]
        public int additionalPlantfood { get; set; }

        [JsonProperty("Zombies")]
        public List<Zombie> zombies { get; set; }
    }

    public class SpawnModernPortalsWaveActionProps : ObjData
    {
        [JsonProperty("PortalColumn")]
        public int portalColumn { get; set; }

        [JsonProperty("PortalRow")]
        public int portalRow { get; set; }

        [JsonProperty("PortalType")]
        public string portalType { get; set; }

        [JsonProperty("SpawnEffectAnimID")]
        public string spawnEffectAnimID { get; set; }

        [JsonProperty("SpawnSoundID")]
        public string spawnSoundID { get; set; }
    }

    public class WaveManagerModuleProperties : ObjData
    {
        [JsonProperty("DynamicZombies")]
        public List<DynamicZombie> dynamicZombies { get; set; }

        [JsonProperty("WaveManagerProps")]
        public string waveManagerProps { get; set; }
    }

    #region Grid Item Classes
    public enum TileObjectType
    {
        Empty,
        Gravestone,
        SandSlide
    }

    public class GridTile
    {
        public int GridX;
        public int GridY;
        public HashSet<TileObjectType> ObjectTypes = new();
    }


    public class GravestoneProperties : ObjData
    {
        public List<GravestoneForceSpawnData> ForceSpawnData { get; set; }
    }

    public class GravestoneForceSpawnData
    {
        public int GridX { get; set; }
        public int GridY { get; set; }
    }

    public class SandSlideProperties : ObjData
    {
        [JsonProperty("ForceSpawnData")]
        public List<SandSlideForceSpawnData> ForceSpawnData { get; set; }
    }

    public class SandSlideForceSpawnData
    {
        public int GridX { get; set; }
        public int GridY { get; set; }
    }

    #endregion

    #region Row Item Classes
    public enum RowObjectType
    {
        PiratePlankRow
    }

    public class PiratePlankProperties : ObjData
    {
        [JsonProperty("PlankRows")]
        public List<int> PlankRows { get; set; } = new();
    }
    #endregion

    public class ObjDataConverter : JsonConverter
    {
        private static readonly Dictionary<string, Type> _typeMap = new(StringComparer.OrdinalIgnoreCase)
        {
            ["LevelDefinition"] = typeof(LevelDefinition),
            ["MausoleumLaneProperties"] = typeof(MausoleumLaneProperties),
            ["WaveManagerProperties"] = typeof(WaveManagerProperties),
            ["SpawnZombiesJitteredWaveActionProps"] = typeof(SpawnZombiesJitteredWaveActionProps),
            ["SpawnModernPortalsWaveActionProps"] = typeof(SpawnModernPortalsWaveActionProps),
            ["WaveManagerModuleProperties"] = typeof(WaveManagerModuleProperties),
            ["SeedBankProperties"] = typeof(SeedBankProperties),
            ["PiratePlankProperties"] = typeof(PiratePlankProperties),
            ["GravestoneProperties"] = typeof(GravestoneProperties),
            ["SandSlideProperties"] = typeof(SandSlideProperties)
        };

        public override bool CanConvert(Type objectType) => objectType == typeof(GameObject);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string objclass = jo["objclass"]?.ToString();
            JToken objdataToken = jo["objdata"];

            ObjData objdata = null;
            if (!string.IsNullOrEmpty(objclass) && ObjDataConverter._typeMap.TryGetValue(objclass, out var type))
            {
                objdata = (ObjData)objdataToken.ToObject(type, serializer);
            }

            return new GameObject
            {
                aliases = jo["aliases"]?.ToObject<List<string>>(serializer),
                objclass = objclass,
                objdata = objdata
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var go = (GameObject)value;
            var jo = new JObject
            {
                ["aliases"] = go.aliases != null ? JToken.FromObject(go.aliases, serializer) : null,
                ["objclass"] = go.objclass,
                ["objdata"] = go.objdata != null ? JToken.FromObject(go.objdata, serializer) : null
            };
            jo.WriteTo(writer);
        }
    }
}
