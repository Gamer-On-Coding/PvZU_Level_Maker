using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.AccessControl;
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

        public static void AddBasicLevelDefinition(string pathname, World world, int levelNumber, Level level)
        {
            LevelDefinition definition = new()
            {
                description = world.world_description,
                levelNumber = levelNumber,
            };

            GameObject LevelDefinition = new()
            {
                objclass = "LevelDefinition",
                objdata = definition
            };

            level.objects.Add(LevelDefinition);

            string json = JsonConvert.SerializeObject(level);
            
            try
            {
                json = JToken.Parse(json).ToString(Newtonsoft.Json.Formatting.Indented);
            }
            catch
            {
            }

            File.WriteAllText(pathname, json);
        }
/*
        public static void LoadLevel()
        {

        }

        public static void AddSeedBank(string pathname)
        {
        }

        public static void AddSeedsBank(string pathname)
        {
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
*/
    }
}