using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  internal class SBSubActionsList
  {
    public string? Name { get; set; }
    public List<SBSubActionsList>? Items { get; set; }

    static List<SBSubActionsList> subSubCollection = new List<SBSubActionsList>()
    {
      new SBSubActionsList { Name = "SubSubCore" },
      new SBSubActionsList { Name = "SubSubOBS" },
      new SBSubActionsList { Name = "SubSubPolyPop" },
      new SBSubActionsList { Name = "SubSubSettings" },
      new SBSubActionsList { Name = "SubSubSpeaker.bot" },
      new SBSubActionsList { Name = "SubSubStreamlabs Desktop" },
      new SBSubActionsList { Name = "SubSubYouTube" },
      new SBSubActionsList { Name = "SubSubElgato" },
      new SBSubActionsList { Name = "SubSubIntegrations" },
      new SBSubActionsList { Name = "SubSubTrovo" },
      new SBSubActionsList { Name = "SubSubTwitch" },
      new SBSubActionsList { Name = "SubSubVStream" }
    };

    static List<SBSubActionsList> subCollection = new List<SBSubActionsList>(){
        new SBSubActionsList { Name = "SubCore", Items = subSubCollection },
        new SBSubActionsList { Name = "SubOBS", Items = subSubCollection },
        new SBSubActionsList { Name = "SubPolyPop", Items = subSubCollection },
        new SBSubActionsList { Name = "SubSettings", Items = subSubCollection },
        new SBSubActionsList { Name = "SubSpeaker.bot", Items = subSubCollection },
        new SBSubActionsList { Name = "SubStreamlabs Desktop", Items = subSubCollection },
        new SBSubActionsList { Name = "SubYouTube", Items = subSubCollection },
        new SBSubActionsList { Name = "SubElgato", Items = subSubCollection },
        new SBSubActionsList { Name = "SubIntegrations", Items = subSubCollection },
        new SBSubActionsList { Name = "SubTrovo", Items = subSubCollection },
        new SBSubActionsList { Name = "SubTwitch", Items = subSubCollection },
        new SBSubActionsList { Name = "SubVStream", Items = subSubCollection }
    };

    public static List<SBSubActionsList> GetAll()
    {
      return new List<SBSubActionsList>{
        new SBSubActionsList { Name = "Core", Items = subCollection },
        new SBSubActionsList { Name = "OBS", Items = subCollection },
        new SBSubActionsList { Name = "PolyPop", Items = subCollection },
        new SBSubActionsList { Name = "Settings", Items = subCollection },
        new SBSubActionsList { Name = "Speaker.bot", Items = subCollection },
        new SBSubActionsList { Name = "Streamlabs Desktop", Items = subCollection },
        new SBSubActionsList { Name = "YouTube", Items = subCollection },
        new SBSubActionsList { Name = "Elgato", Items = subCollection },
        new SBSubActionsList { Name = "Integrations", Items = subCollection },
        new SBSubActionsList { Name = "Trovo", Items = subCollection },
        new SBSubActionsList { Name = "Twitch", Items = subCollection },
        new SBSubActionsList { Name = "VStream", Items = subCollection }
      };
    }
  }
}
