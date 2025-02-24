using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZU_Level_Maker
{
    public static class LinqExtension
    {
        public static IEnumerable<string> ToID(this IEnumerable<Module> source)
        {
            List<string> result = new List<string>();
            foreach (var module in source)
            {
                result.Add(module.module_id);
            }
            return result;
        }

    }
}
