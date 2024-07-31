using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace PvZU_Level_Maker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LevelMaker());
        }

        public static void AddLevelDefinition(string pathname, World world)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement level_definition = doc.CreateElement("LevelDefinition");

            XmlElement description = doc.CreateElement("Description");
            description.InnerText = "[PLAYERS_TRIP_TO]";
            level_definition.AppendChild(description);

            XmlElement world_num = doc.CreateElement("WorldNum");
            world_num.InnerText = world.world_num.ToString();
            level_definition.AppendChild(world_num);

            XmlElement level_name = doc.CreateElement("Name");
            level_name.InnerText = "[LEVEL_NAME]";
            level_definition.AppendChild(level_name);


            root.AppendChild(level_definition);

            doc.Save(pathname);
        }

        public static void AddSeedBank(string pathname)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement seed_bank = doc.CreateElement("SeedBank");
            root.AppendChild(seed_bank);

            doc.Save(pathname);
        }

        public static void AddSeedsBank(string pathname)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement seeds_bank = doc.CreateElement("SeedsBank");
            root.AppendChild(seeds_bank);

            doc.Save(pathname);
        }

        public static void AddFirstReward(string pathname)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement FirstRewardType = doc.CreateElement("FirstRewardType");
            FirstRewardType.InnerText = "";
            root.AppendChild(FirstRewardType);

            XmlElement FirstRewardParam = doc.CreateElement("FirstRewardParam");
            FirstRewardParam.InnerText = "";
            root.AppendChild(FirstRewardParam);

            doc.Save(pathname);
        }

        public static void SetZombiePool(string pathname)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement ZombiePool = doc.CreateElement("ZombiePool");
            root.AppendChild(ZombiePool);

            doc.Save(pathname);
        }

        public static void AddWaves(string pathname)
        {
            XmlDocument doc = new();
            doc.Load(pathname);

            XmlNode root = doc.SelectSingleNode("LEVEL");

            XmlElement waves = doc.CreateElement("Waves");
            root.AppendChild(waves);

            doc.Save(pathname);
        }
    }
}