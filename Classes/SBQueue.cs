using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Classes
{
    public class SBQueue
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public bool Blocking { get; set; }

        public static List<SBQueue> GetAll()
        {
            return new List<SBQueue>()
            {
                new SBQueue() { ID = "0", Name = "soundalerts", Blocking = true },
                new SBQueue() { ID = "1", Name = "game"},
                new SBQueue() { ID = "2", Name = "chat"},
                new SBQueue() { ID = "3", Name = "brb"}
            };
        }
    }
}
