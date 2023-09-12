using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Classes
{
    public class SBTrigger
    {
        public uint ID { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public bool Enabled { get; set; }
        public string Criteria { get; set; }

        public static ObservableCollection<SBTrigger> GetAll()
        {
            return new ObservableCollection<SBTrigger>(){
                new SBTrigger() { ID = 0, Source = "Twitch", Type="Cheer", Enabled = true,  Criteria="Between 100 and 200" },
                new SBTrigger() { ID = 1, Source = "YouTube", Type="Cheer", Enabled = true, Criteria="Between 100 and 200" },
                new SBTrigger() { ID = 2, Source = "OBS", Type="Event", Enabled = true, Criteria="Between 100 and 200" },
                new SBTrigger() { ID = 3, Source = "WebSocket", Type="Message", Enabled = true, Criteria="Between 100 and 200" },
                new SBTrigger() { ID = 3, Source = "VoiceControl", Type="Event", Enabled = true, Criteria="Between 100 and 200" }
            };
        }

    }
}
