using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PvZU_Level_Maker
{
    public class World
    {
        public required string world_name;
        public required string world_id;
        public required int world_num;

        public override string ToString() => world_name;
    }

    public class FirstRewardType
    {
        public required string reward_name;
        public required string reward_id;

        public override string ToString() => reward_name;
    }
}
