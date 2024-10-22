using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public enum RoleType
  {
    Broadcaster,
    Mod,
    VIP,
    Viewer,
    Anonymous
  }

  public enum RoleTypeIcon
  {
    Video,
    Sword,
    Diamond,
    EyeOutline,
    Incognito
  }

  public enum AccountType
  {
    Broadcaster,
    Bot
  }

  public enum Platform
  {
    Twitch,
    YouTube,
    Trovo
  }

  public enum PlatformIcon
  {
    Twitch,
    YouTube,
    AlphaT
  }
}
