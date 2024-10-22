using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public class SBTrigger
  {
    public string? ID { get; set; }
    public uint Type { get; set; }
    public bool Enabled { get; set; }
    public bool AlwaysRun { get; set; }
    public string? Criteria { get; set; }
    public Platform Source { get; set; }
  }
}
