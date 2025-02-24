namespace PvZU_Level_Maker
{
    public class Plant
    {
        public string aliases;
        public string objects;
        public string sprite;
        public string worldtype;
        public Basic basic;
        public Card card;

        public class Basic
        {
            public int health;
        }

        public class Card
        {
            public int cooldown;
            public int cost;
            public int gridsort;
        }
    }
    public class PlantConfig
    {
        public List<Plant> objects { get; set; }
    }

    public class ZombieObj
    {
        public string Aliases { get; set; }
        public string Object { get; set; }
        public string Sprite { get; set; }
        public string Parent { get; set; } // Optional, not present in all JSON objects
        public string WorldType { get; set; }
        public BasicAttributes Basic { get; set; }

        public class BasicAttributes
        {
            public int Health { get; set; }
            public List<int> HealthDividing { get; set; } = [];
            public int? Armor { get; set; } // Nullable to handle cases where armor is not present
            public List<int> ArmorDividing { get; set; } = []; // Nullable to handle cases where armor dividing is not present
            public int? ArmorType { get; set; } // Nullable to handle cases where armor type is not present
            public float Speed { get; set; }
        }
    }
    public class ZombieConfig
    {
        public List<ZombieObj> objects { get; set; }
    }
}