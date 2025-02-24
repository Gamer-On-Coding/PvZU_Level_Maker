using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PvZU_Level_Maker
{
    public abstract class ObjData
    {
    }

    public class LevelDefinition : ObjData
    {
        [JsonPropertyName("Description")]
        public string description { get; set; }

        [JsonPropertyName("FirstIntroNarrative")]
        public string firstIntroNarrative { get; set; }

        [JsonPropertyName("FirstRewardParam")]
        public string firstRewardParam { get; set; }

        [JsonPropertyName("FirstRewardType")]
        public string firstRewardType { get; set; }

        [JsonPropertyName("LevelNumber")]
        public int levelNumber { get; set; }

        [JsonPropertyName("Loot")]
        public string loot { get; set; }

        [JsonPropertyName("Modules")]
        public List<string> modules { get; set; }

        [JsonPropertyName("Name")]
        public string name { get; set; }

        [JsonPropertyName("NormalPresentTable")]
        public string normalPresentTable { get; set; }

        [JsonPropertyName("ShinyPresentTable")]
        public string shinyPresentTable { get; set; }

        [JsonPropertyName("StageModule")]
        public string stageModule { get; set; }
    }

    public class MausoleumLaneProperties : ObjData
    {
        [JsonPropertyName("LaneGrids")]
        public List<LaneGrid> laneGrids { get; set; }
    }

    public class SeedBankProperties : ObjData
    {
        [JsonPropertyName("SelectionMethod")]
        public string selectionMethod { get; set; }
    }

    public class WaveManagerModuleProperties : ObjData
    {
        [JsonPropertyName("DynamicZombies")]
        public List<DynamicZombie> dynamicZombies { get; set; }

        [JsonPropertyName("WaveManagerProps")]
        public string waveManagerProps { get; set; }
    }

    public class WaveManagerProperties : ObjData
    {
        [JsonPropertyName("FlagWaveInterval")]
        public int flagWaveInterval { get; set; }

        [JsonPropertyName("WaveCount")]
        public int waveCount { get; set; }

        [JsonPropertyName("WaveSpendingPointIncrement")]
        public int waveSpendingPointIncrement { get; set; }

        [JsonPropertyName("WaveSpendingPoints")]
        public int waveSpendingPoints { get; set; }

        [JsonPropertyName("Waves")]
        public List<List<string>> waves { get; set; }
    }

    public class SpawnZombiesJitteredWaveActionProps : ObjData
    {
        [JsonPropertyName("AdditionalPlantfood")]
        public int additionalPlantfood { get; set; }

        [JsonPropertyName("Zombies")]
        public List<Zombie> zombies { get; set; }
    }

    public class SpawnModernPortalsWaveActionProps : ObjData
    {
        [JsonPropertyName("PortalColumn")]
        public int portalColumn { get; set; }

        [JsonPropertyName("PortalRow")]
        public int portalRow { get; set; }

        [JsonPropertyName("PortalType")]
        public string portalType { get; set; }

        [JsonPropertyName("SpawnEffectAnimID")]
        public string spawnEffectAnimID { get; set; }

        [JsonPropertyName("SpawnSoundID")]
        public string spawnSoundID { get; set; }
    }
}