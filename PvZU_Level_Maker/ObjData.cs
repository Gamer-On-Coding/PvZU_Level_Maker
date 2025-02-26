using Newtonsoft.Json;

namespace PvZU_Level_Maker
{
    public abstract class ObjData
    {
    }

    public class LevelDefinition : ObjData
    {
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
        [JsonProperty("SelectionMethod")]
        public string selectionMethod { get; set; }
    }

    public class WaveManagerModuleProperties : ObjData
    {
        [JsonProperty("DynamicZombies")]
        public List<DynamicZombie> dynamicZombies { get; set; }

        [JsonProperty("WaveManagerProps")]
        public string waveManagerProps { get; set; }
    }

    public class WaveManagerProperties : ObjData
    {
        [JsonProperty("FlagWaveInterval")]
        public int flagWaveInterval { get; set; }

        [JsonProperty("WaveCount")]
        public int waveCount { get; set; }

        [JsonProperty("WaveSpendingPointIncrement")]
        public int waveSpendingPointIncrement { get; set; }

        [JsonProperty("WaveSpendingPoints")]
        public int waveSpendingPoints { get; set; }

        [JsonProperty("Waves")]
        public List<List<string>> waves { get; set; }
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
}