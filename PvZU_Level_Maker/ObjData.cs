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

    public class ObjDataConverter : JsonConverter
    {
        private static readonly Dictionary<string, Type> _typeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            ["LevelDefinition"] = typeof(LevelDefinition),
            ["MausoleumLaneProperties"] = typeof(MausoleumLaneProperties),
            ["WaveManagerProperties"] = typeof(WaveManagerProperties),
            ["SpawnZombiesJitteredWaveActionProps"] = typeof(SpawnZombiesJitteredWaveActionProps),
            ["SpawnModernPortalsWaveActionProps"] = typeof(SpawnModernPortalsWaveActionProps),
            ["WaveManagerModuleProperties"] = typeof(WaveManagerModuleProperties),
            ["SeedBankProperties"] = typeof(SeedBankProperties)
        };

        public override bool CanConvert(Type objectType)
        {
            return typeof(ObjData).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);

            // Create a new serializer without this converter to prevent recursion
            var newSerializer = new JsonSerializer();
            foreach (var converter in serializer.Converters.Where(c => !(c is ObjDataConverter)))
            {
                newSerializer.Converters.Add(converter);
            }

            // Copy other settings
            newSerializer.NullValueHandling = serializer.NullValueHandling;
            newSerializer.MissingMemberHandling = serializer.MissingMemberHandling;
            Console.WriteLine("Parsing object: " + jo.ToString());

            // Try to use objclass if present
            if (jo["objclass"] != null)
            {
                string objclass = jo["objclass"].Value<string>();
                Console.WriteLine("Detected objclass: " + objclass);
                if (_typeMap.TryGetValue(objclass, out Type concreteType))
                {
                    return jo.ToObject(concreteType, newSerializer);
                }
            }

            // Try to infer type by matching known property sets
            foreach (var kvp in _typeMap)
            {
                var type = kvp.Value;
                var props = type.GetProperties().Select(p =>
                {
                    var attr = p.GetCustomAttributes(typeof(JsonPropertyAttribute), true)
                                .Cast<JsonPropertyAttribute>().FirstOrDefault();
                    return attr?.PropertyName ?? p.Name;
                }).ToList();

                if (props.All(pn => jo[pn] != null))
                {
                    return jo.ToObject(type, newSerializer);
                }
            }

            // Fallback for partial matches (at least one property matches)
            foreach (var kvp in _typeMap)
            {
                var type = kvp.Value;
                var props = type.GetProperties().Select(p =>
                {
                    var attr = p.GetCustomAttributes(typeof(JsonPropertyAttribute), true)
                                .Cast<JsonPropertyAttribute>().FirstOrDefault();
                    return attr?.PropertyName ?? p.Name;
                }).ToList();

                if (props.Any(pn => jo[pn] != null))
                {
                    return jo.ToObject(type, newSerializer);
                }
            }

            // If still unknown, log all keys for debugging
            var keys = string.Join(", ", jo.Properties().Select(p => p.Name));
            Console.WriteLine($"Unknown JSON object with keys: {keys}");

            throw new JsonSerializationException($"Cannot determine ObjData type. JSON keys: {keys}");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Create a new serializer without this converter
            var newSerializer = new JsonSerializer();
            foreach (var converter in serializer.Converters.Where(c => !(c is ObjDataConverter)))
            {
                newSerializer.Converters.Add(converter);
            }

            newSerializer.Serialize(writer, value);
        }
    }
}
