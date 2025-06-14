using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point 
        public static Level level = new() { objects = new List<GameObject> { } };
        public static string filename;
        public static string pathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string filepath;

        public static List<Plant> plants = [];
        public static List<ZombieTypeWrapper> zombies = [];

        public static bool loadingFile = false;

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

            WriteToFile(filepath);
        }

        public static void WriteToFile(string filename)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore // Removes all null values
            };

            // Serialize while ignoring null values
            string json = JsonConvert.SerializeObject(level, settings);

            // Format JSON to be more readable
            try
            {
                json = JToken.Parse(json).ToString(Newtonsoft.Json.Formatting.Indented);
            }
            catch
            {
                // Optional: Handle formatting errors if needed
            }

            // Write JSON to file
            File.WriteAllText(filename, json);
        }


        public static void ReadConfigs()
        {
            string plantstring = File.ReadAllText("Configs/PLANTCONFIG.json");
            string zombiestring = File.ReadAllText("Configs/ZOMBIETYPES.json");

            plants = JsonConvert.DeserializeObject<PlantConfig>(plantstring).objects;

            zombies = JsonConvert.DeserializeObject<ZombieTypeRoot>(zombiestring).objects;
        }
        public static Level LoadLevel(string filename)
        {
                var settings = new JsonSerializerSettings
                {
                    Converters = { new ObjDataConverter() },
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                string json = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<Level>(json, settings);
        }
        public static class JsonExtensions
        {
            public static T DeserializeWithConverter<T>(string json)
            {
                var settings = new JsonSerializerSettings
                {
                    Converters = { new ObjDataConverter() },
                    NullValueHandling = NullValueHandling.Ignore
                };
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
        }
        public static string GetRTIDFromSprite(string spriteName)
        {
            var match = Program.zombies.FirstOrDefault(z => z.aliases[0] == spriteName);
            return match != null ? $"RTID({match.aliases[0]}@ZombieTypes)" : spriteName;
        }
    }
}