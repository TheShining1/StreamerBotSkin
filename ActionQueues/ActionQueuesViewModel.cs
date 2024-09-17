using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using ReactiveUI;

using StreamerBotSkin.Views;

namespace StreamerBotSkin.ViewModels
{
  public class ActionQueuesViewModel : ViewModelBase
  {
    public string Name { get; set; } = "ActionQueuesViewModel";

    public ActionQueuesViewModel()
    {
      currentQueuesViewModel = QueuesViewModelsAvailable["pending"];

      NavigateSettingsCommand = ReactiveCommand.Create<string>(NavigateToSetting);
    }

    private readonly Dictionary<string, ViewModelBase> QueuesViewModelsAvailable = new Dictionary<string, ViewModelBase>
    {
        //{"main", new ActionQueuesViewModel() },
        {"pending", new ActionsHistoryViewModel() },
        //{"queues", new IntegrationsSettingsViewModel() },
        //{"history", new StreamappsSettingsViewModel() }
    };

    public ICommand NavigateSettingsCommand { get; }

    private void NavigateToSetting(string key)
    {
      CurrentQueuesViewModel = QueuesViewModelsAvailable[key];
    }

    private ViewModelBase currentQueuesViewModel;
    public ViewModelBase CurrentQueuesViewModel
    {
      get => currentQueuesViewModel;
      private set => this.RaiseAndSetIfChanged(ref currentQueuesViewModel, value);
    }
  }
}
