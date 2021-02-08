using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class PrefList
    {
        public List<string> Pref { get; }
        public PrefList()
        {
            Pref = new List<string>();
            Pref.Add("北海道");
            Pref.Add("沖縄");
            Pref.Add("東京");
        }
    }
}
