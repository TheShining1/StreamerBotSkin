using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace StreamerBotSkin.Models
{
  public class SBAccount
  {
    public string Name { get; set; }
    public AccountType AccType { get; set; }
    public Platform AccountPlatform { get; set; }
    public string Level { get; set; }

    SBAccount(string name, AccountType accountType, Platform platform)
    {
      Name = name;
      AccType = accountType;
      AccountPlatform = platform;
      Level = String.Empty;
    }

    public static ObservableCollection<SBAccount> GetAll()
    {
      var accounts = new ObservableCollection<SBAccount>();

      foreach (var platform in (Platform[])Enum.GetValues(typeof(Platform)))
      {
        foreach (var accType in (AccountType[])Enum.GetValues(typeof(AccountType)))
        {
          accounts.Add(new SBAccount($"ShiningOne{(accType == AccountType.Bot ? "Bot" : "")}", accType, platform));
        }
      }

      return accounts;
    }
  }
}
