using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace StreamerBotSkin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _currentViewModel = ViewModelsAvailable["main"];

            NavigateCommand = ReactiveCommand.Create<string>(NavigateTo);
        }

        private readonly Dictionary<string,ViewModelBase> ViewModelsAvailable = new Dictionary<string, ViewModelBase>
        {
            {"main", new MainViewModel() },
            {"actions", new ActionsViewModel() },
            {"settings", new SettingsViewModel() }
        };

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _currentViewModel, value);
        }
        public ICommand NavigateCommand { get; }

        private string index = "main";
        private void NavigateTo(string key)
        {
            CurrentViewModel = ViewModelsAvailable[key];
        }
    }
}