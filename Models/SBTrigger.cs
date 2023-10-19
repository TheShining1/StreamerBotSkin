using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
    internal class SBTrigger
    {
        public uint ID { get; set; }
        public uint Type { get; set; }
        public bool Enabled { get; set; }
        public bool AlwaysRun { get; set; }
    }
}
