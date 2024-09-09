using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;

using StreamerBotSkin.Models;

using StreamerBotSkin.ViewModels;

namespace StreamerBotSkin.ViewModels
{
  public class ViewersViewModel : ViewModelBase
  {
    public List<SBUser> users { get; set; } = SBUser.GetAll();

    private SBUser _selectedUser;
    public SBUser selectedUser
    {
      get { return _selectedUser; }
      set
      {
        this.RaiseAndSetIfChanged(ref _selectedUser, value);
      }
    }
  }
}
