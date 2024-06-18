using System.Reactive;
using System.Collections.ObjectModel;
using StreamerBotSkin.Models;
using System.Collections.Generic;
using System.Linq;

namespace StreamerBotSkin.ViewModels
{
  internal class PlatfromsSettingsViewModel : ViewModelBase
  {
    public Dictionary<Platform, Dictionary<AccountType, SBAccount>> accounts { get; set; }

    public PlatfromsSettingsViewModel()
    {
      accounts = SBAccount.GetAll()
        .GroupBy(acc => acc.AccountPlatform)
        .ToDictionary(
          p => p.Key,
          p => p.GroupBy(acc => acc.AccType)
            .ToDictionary(
              t => t.Key,
              t => t.First()
        ));
    }
  }
}