using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  public class OBSSettingsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    public List<SBOBSConnection> OBSSettings { get; set; } = new ()
    {
      new SBOBSConnection{
        ID = 0,
        Name = "main",
        Host = "localhost",
        Port = 4545,
        Password = "",
        Version = "v5.x",
        AutoConnect = false,
        Reconnect = false,
        Retry = 30,
        Status = "disconnected"
      }
    };
  }
}
