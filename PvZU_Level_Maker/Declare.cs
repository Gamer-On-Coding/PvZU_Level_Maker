namespace PvZU_Level_Maker
{
    public class Declare
    {
        #region World Declaration
        //Worlds
        public static readonly World EM = new() { world_name = "Emperors Mausoleum", world_id = "MAUSOLEUM", comment_name = "Mausoleum", world_description = "[PLAYERS_TRIP_TO_MAUSOLEUM]" };
        public static readonly World AE = new() { world_name = "Ancient Egypt", world_id = "" };
        public static readonly World PS = new() { world_name = "Pirate Seas", world_id = "" };
        public static readonly World WW = new() { world_name = "Wild West", world_id = "" };
        public static readonly World KW = new() { world_name = "Kong-Fu World", world_id = "" };
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
        #endregion

        #region First Reward Type Declaration
        public static readonly RewardType Plant = new() { typeName = "Plant", typeID = "unlock_plant" };
        public static readonly RewardType Collectable = new() { typeName = "Collectable", typeID = "collectable" };
        #endregion

        #region Loot Decleration
        public static readonly Loot defaultLoot = new() { LootID = "RTID(DefaultLoot@LevelModules", LootName = "Default" };
        public static readonly Loot noLoot = new() { LootID = "NoLoot@LevelModules", LootName = "No Loot" };
        public static readonly Loot dangerRoomLoot = new() { LootID = "", LootName = "Danger Room" };
        #endregion
    }
}
