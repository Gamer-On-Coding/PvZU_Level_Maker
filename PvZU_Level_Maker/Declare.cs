namespace PvZU_Level_Maker
{
    public class Declare
    {
        #region World Declaration
        //Worlds
        public static readonly World EM = new() { world_name = "Emperors Mausoleum", world_id = "MAUSOLEUM", comment_name = "Mausoleum", world_description = "[PLAYERS_TRIP_TO_MAUSOLEUM]", level_name_format = "[MAUSOLEUM_LEVEL_NAME]" };
        public static readonly World AE = new() { world_name = "Ancient Egypt", world_id = "EGYPT", comment_name = "Egypt", world_description = "[PLAYERS_TRIP_TO_EGYPT]", level_name_format = "[EGYPT_LEVEL_NAME]" };
        public static readonly World PS = new() { world_name = "Pirate Seas", world_id = "PIRATE", comment_name = "Pirate", world_description = "[PLAYERS_TRIP_TO_PIRATE_SEAS]", level_name_format = "[PIRATE_LEVEL_NAME]" };
        public static readonly World WW = new() { world_name = "Wild West", world_id = "WILDWEST", comment_name = "WildWest", world_description = "[PLAYERS_TRIP_TO_WILD_WEST]", level_name_format = "[WILDWEST_LEVEL_NAME]" };
        public static readonly World KW = new() { world_name = "Kong-Fu World", world_id = "KONGFU", comment_name = "KongFu", world_description = "[PLAYERS_TRIP_TO_KONGFU]", level_name_format = "[KONGFU_LEVEL_NAME]" };
        #endregion

        #region Module Decleration
        //Intros
        public static readonly Module StandardIntro = new() { module_name = "Standard Intro", module_id = "RTID(StandardIntro@LevelModules)" };

        //Sun Droppers
        public static readonly Module DefaultSunDropper = new() { module_name = "Default Sun Dropper", module_id = "RTID(DefaultSunDropper@LevelModules)" };
        public static readonly Module VerySlowSunDropper = new() { module_name = "Very Slow Sun Dropper", module_id = "RTID(VerySlowSunDropper@LevelModules)" };
        public static readonly Module SlowSunDropper = new() { module_name = "Slow Sun Dropper", module_id = "RTID(SlowSunDropper@LevelModules)" };
        public static readonly Module VeryFastSunDropper = new() { module_name = "Very Fast Sun Dropper", module_id = "RTID(VeryFastSunDropper@LevelModules)" };
        public static readonly Module FastSunDropper = new() { module_name = "Fast Sun Dropper", module_id = "RTID(FastSunDropper@LevelModules)" };

        //Mowers
        public static readonly Module TutorialMowers = new() { module_name = "Tutorial Mowers", module_id = "RTID(TutorialMowers@LevelModules)" };
        public static readonly Module MausoleumMowers = new() { module_name = "Mausoleum Mowers", module_id = "RTID(MausoleumMowers@LevelModules)" };
        public static readonly Module ModernMowers = new() { module_name = "Modern Mowers", module_id = "RTID(ModernMowers@LevelModules)" };

        public static readonly Module ZombiesDeadWinCon = new() { module_name = "Zombies Dead Win Condition", module_id = "RTID(ZombiesDeadWinCon@LevelModules)" };
        public static readonly Module MausoleumLane = new() { module_name = "Mausoleum Lane", module_id = "RTID(MausoleumLane@CurrentLevel)" };
        public static readonly Module SeedBank = new() { module_name = "Seed Bank", module_id = "RTID(SeedBank@CurrentLevel)" };
        public static readonly Module DefaultZombieWinCondition = new() { module_name = "Default Zombie Win Condition", module_id = "RTID(DefaultZombieWinCondition@LevelModules)" };
        public static readonly Module WaveManagerProps = new() { module_name = "Wave Manager Props", module_id = "RTID(WaveManagerProps@CurrentLevel)" };

        #endregion

        #region Stage Module Decleration
        public static readonly StageModule ModernStage = new() { name = "Modern Stage", id = "RTID(ModernStage@LevelModules)" };
        public static readonly StageModule MausoleumStage = new() { name = "Mausoleum Stage", id = "RTID((MausoleumStage@LevelModules)" };
        public static readonly StageModule NightStage = new() { name = "Night Stage", id = "RTID(NightStage@LevelModules)" };
        #endregion

        #region First Reward Type Declaration
        public static readonly RewardType Plant = new() { typeName = "Plant", typeID = "unlock_plant" };
        public static readonly RewardType Collectable = new() { typeName = "Collectable", typeID = "collectable" };
        public static readonly RewardType Coins = new() { typeName = "Coins", typeID = "reward_coins" };
        public static readonly RewardType Costume = new() { typeName = "Costume", typeID = "reward_costume" };
        #endregion

        #region Loot Decleration
        public static readonly Loot defaultLoot = new() { LootID = "RTID(DefaultLoot@LevelModules", LootName = "Default" };
        public static readonly Loot noLoot = new() { LootID = "NoLoot@LevelModules", LootName = "No Loot" };
        public static readonly Loot dangerRoomLoot = new() { LootID = "", LootName = "Danger Room" };
        public static readonly Loot miniGameLoot = new() { LootID = "RTID(MiniGameLoot@LevelModules)", LootName = "Mini-Game Loot" };
        public static readonly Loot hardModeLoot = new() { LootID = "RTID(HardModeLoot@LevelModules)", LootName = "Hard Mode Loot" };
        #endregion

        #region Portal Type Decleration
        public static readonly PortalType IcePortal = new() { name = "Ice Portal", id = "ice" };
        public static readonly PortalType FirePortal = new() { name = "Fire Portal", id = "fire" };
        public static readonly PortalType ShadowPortal = new() { name = "Shadow Portal", id = "shadow" };
        #endregion

        #region Spawn Effect
        public static readonly SpawnEffect DefaultEffect = new() { name = "Default Portal Effect", effectID = "FX_PortalOpen" };
        public static readonly SpawnEffect BigBoom = new() { name = "Big Explosion", effectID = "FX_BigExplosion" };
        #endregion

        #region Spawn Sound
        public static readonly SpawnSound PortalSound = new() { name = "Portal Open", soundID = "SFX_Zombie_Portal" };
        public static readonly SpawnSound PlantfoodReady = new() { name = "Plantfood Ready", soundID = "SFX_Plantfood_Ready" };
        #endregion

        #region Wave Manager Props
        public static readonly WaveManagerProps DefaultWaves = new() { name = "Default", id = "RTID(WaveManagerProps@CurrentLevel)" };
        public static readonly WaveManagerProps FastWaves = new() { name = "Fast Waves", id = "RTID(FastWaveManagerProps@CurrentLevel)" };
        #endregion
    }
}
