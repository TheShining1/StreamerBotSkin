using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public class SBPolyPopConnection
  {
    public bool AutoStart { get; set; }
    public string? Host { get; set; }
    public uint Port { get; set; }
    public string? Endpoint { get; set; }
  }
}
