using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public class SBSLDConnection
  {
    public string? Name { get; set; }
    public string? Host { get; set; }
    public uint Port { get; set; }
    public string? Token { get; set; }
    public bool AutoConnect { get; set; }
    public bool Reconnect { get; set; }
    public uint Retry { get; set; }
    public string? Status { get; set; }
  }
}
