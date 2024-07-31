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
        public static readonly World EM = new() { world_name = "Emperors Mausoleum", world_id = "秦始皇陵", world_num = 2 };
        public static readonly World AE = new() { world_name = "Ancient Egypt", world_id = "上古埃及", world_num = 1 };
        public static readonly World PS = new() { world_name = "Pirate Seas", world_id = "海盗港湾", world_num = 7 };
        public static readonly World WW = new() { world_name = "Wild West", world_id = "狂野西部", world_num = 8 };
        public static readonly World KW = new() { world_name = "Kong-Fu World", world_id = "功夫世界", world_num = 5 };

        //Types of First Time Defeat Rewards
        public static readonly FirstRewardType none = new() { reward_name = "None", reward_id = "" };
    }
}
