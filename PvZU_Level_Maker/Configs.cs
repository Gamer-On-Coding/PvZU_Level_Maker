using System.Collections.Generic;

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

    public class ZombieTypeRoot
    {
        public string comment { get; set; }
        public int version { get; set; }
        public List<ZombieTypeWrapper> objects { get; set; }
    }

    public class ZombieTypeWrapper
    {
        public string objclass { get; set; }
        public List<string> aliases { get; set; }
        public ZombieType objdata { get; set; }

        public override string ToString()
        {
            return objdata.Sprite;
        }
    }

    public class ZombieType
    {
        public string Sprite { get; set; }
        public string TypeName { get; set; }
        public string ZombieClass { get; set; }
        public string Properties { get; set; }
        public string HomeWorld { get; set; }
        public bool? IsBasicZombie { get; set; }
        public string Parent { get; set; }
        public string FlagType { get; set; }
        public bool? Placeable { get; set; }
        public int? SkillType { get; set; }
        public bool? InLane { get; set; }
        public bool? HastyOnStart { get; set; }
    }
}