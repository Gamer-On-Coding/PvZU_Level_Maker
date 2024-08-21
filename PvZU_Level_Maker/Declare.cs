using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PvZU_Level_Maker
{
    public class Declare
    {
        //Worlds
        public static readonly World EM = new() { world_name = "Emperors Mausoleum", world_id = "MAUSOLEUM", world_description = "[PLAYERS_TRIP_TO_MAUSOLEUM]" };
        public static readonly World AE = new() { world_name = "Ancient Egypt", world_id = "上古埃及" };
        public static readonly World PS = new() { world_name = "Pirate Seas", world_id = "海盗港湾" };
        public static readonly World WW = new() { world_name = "Wild West", world_id = "狂野西部" };
        public static readonly World KW = new() { world_name = "Kong-Fu World", world_id = "功夫世界" };

        //Types of First Time Defeat Rewards
    }
}
