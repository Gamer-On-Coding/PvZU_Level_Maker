using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PvZU_Level_Maker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point 
        public static Level level = new();
        public static string pathname;

        public static List<Plant> plants = [];
        public static List<ZombieObj> zombies = [];

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container TheForm = new();
            Application.Run();
        }

        public static void AddBasicLevelDefinition(World world, int levelNumber, Level level)
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

            WriteToFile(pathname);
        }

        public static void WriteToFile(string pathname)
        {
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

        public static void ReadConfigs()
        {
            string plantstring = File.ReadAllText("Configs/PLANTCONFIG.json");
            string zombiestring = File.ReadAllText("Configs/ZOMBIECONFIG.json");

            plants = JsonConvert.DeserializeObject<PlantConfig>(plantstring).objects;

            zombies = JsonConvert.DeserializeObject<ZombieConfig>(zombiestring).objects;
        }
        public static Level LoadLevel(string pathname)
        {
            string levelstring = File.ReadAllText(pathname);

            level = JsonConvert.DeserializeObject<Level>(levelstring);
            return level;
        }
    }
}