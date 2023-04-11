using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Classes
{
    internal class SBSubAction
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public int Type { get; set; }

        public static List<SBSubAction> GetAll()
        {
            return new List<SBSubAction>()
            {
                new SBSubAction { ID = 0, Name = "SubAction 0", Enabled = true, Type = 0 },
                new SBSubAction { ID = 0, Name = "SubAction 1", Enabled = true, Type = 1 },
                new SBSubAction { ID = 0, Name = "SubAction 2", Enabled = true, Type = 2 }
            };
        }
    }
}
