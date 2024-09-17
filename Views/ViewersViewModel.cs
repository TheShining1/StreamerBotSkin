using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public override string Name => this.GetType().Name;
    private List<SBUser> _users = SBUser.GetAll();
    public List<SBUser> Users
    {
      get => _users;
      set => this.RaiseAndSetIfChanged(ref _users, value);
    }

    private List<SBUser> _usersFiltered = SBUser.GetAll();
    public List<SBUser> UsersFiltered
    {
      get => _usersFiltered;
      set => this.RaiseAndSetIfChanged(ref _usersFiltered, value);
    }

    private bool _isPresent;
    public bool IsPresent
    {
      get => _isPresent;
      set
      {
        this.RaiseAndSetIfChanged(ref _isPresent, value);
        IsPresentFilter();
      }
    }

    private void IsPresentFilter()
    {
      if (!IsPresent)
      {
        UsersFiltered = Users;
        return;
      }

      UsersFiltered = Users.FindAll(u => u.IsPresent == true);
    }

    private SBUser _selectedUser;
    public SBUser SelectedUser
    {
      get { return _selectedUser; }
      set
      {
        this.RaiseAndSetIfChanged(ref _selectedUser, value);
      }
    }
  }
}
