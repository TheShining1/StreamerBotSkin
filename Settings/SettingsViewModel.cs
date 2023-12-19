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
        public string ModelName { get; set; } = "SettingsViewModel";
        public SettingsViewModel()
        {
            _currentSettingsViewModel = SettingsViewModelsAvailable["main"];

            NavigateSettingsCommand = ReactiveCommand.Create<string>(NavigateToSetting);
        }

        private readonly Dictionary<string, ViewModelBase> SettingsViewModelsAvailable = new Dictionary<string, ViewModelBase>
        {
            {"main", new MainSettingsViewModel() },
            {"platforms", new PlatfromsSettingsViewModel() },
            {"integrations", new IntegrationsSettingsViewModel() },
            {"streamapps", new StreamappsSettingsViewModel() }
        };

        public ICommand NavigateSettingsCommand { get; }

        private string index = "main";
        private void NavigateToSetting(string key)
        {
            CurrentSettingsViewModel = SettingsViewModelsAvailable[key];
        }

        private ViewModelBase _currentSettingsViewModel;
        public ViewModelBase CurrentSettingsViewModel
        {
            get => _currentSettingsViewModel;
            private set => this.RaiseAndSetIfChanged(ref _currentSettingsViewModel, value);
        }
    }
}
