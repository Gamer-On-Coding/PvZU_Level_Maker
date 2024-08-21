using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZU_Level_Maker
{
    public abstract class FirstReward
    {
    }

    public class PlantUnlock : FirstReward
    {
        public string Name { get; set; }
    }
}
