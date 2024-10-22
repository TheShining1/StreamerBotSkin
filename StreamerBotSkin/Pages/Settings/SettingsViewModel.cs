using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using ReactiveUI;

namespace StreamerBotSkin.ViewModels
{
  public class SettingsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;

    public SettingsViewModel()
    {
      currentSettingsViewModel = SettingsViewModelsAvailable["main"];

      NavigateSettingsCommand = ReactiveCommand.Create<string>(NavigateToSetting);
    }

    private readonly Dictionary<string, ViewModelBase> SettingsViewModelsAvailable = new Dictionary<string, ViewModelBase>
        {
            {"main", new MainSettingsViewModel() },
            {"platforms", new PlatfromsSettingsViewModel() },
            {"integrations", new IntegrationsSettingsViewModel() },
            {"streamapps", new StreamappsSettingsViewModel() },
            {"timedactions", new TimedActionsViewModel() },
            {"watchers", new WatchersViewModel() },
            {"credits", new CreditsViewModel() },
            {"quotes", new QuotesViewModel() }
        };

    public ICommand NavigateSettingsCommand { get; }

    private void NavigateToSetting(string key)
    {
      CurrentSettingsViewModel = SettingsViewModelsAvailable[key];
    }

    private ViewModelBase currentSettingsViewModel;
    public ViewModelBase CurrentSettingsViewModel
    {
      get => currentSettingsViewModel;
      private set => this.RaiseAndSetIfChanged(ref currentSettingsViewModel, value);
    }
  }
}
