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
      currentViewModel = ViewModelsAvailable["viewers"];

      NavigateCommand = ReactiveCommand.Create<string>(NavigateTo);
    }

    private readonly Dictionary<string, ViewModelBase> ViewModelsAvailable = new()
    {
        {"main", new MainViewModel() },
        {"viewers", new ViewersViewModel() },
        {"actions", new ActionsViewModel() },
        {"queues", new ActionQueuesViewModel() },
        {"settings", new SettingsViewModel() }
    };

    private ViewModelBase currentViewModel;
    public ViewModelBase CurrentViewModel
    {
      get => currentViewModel;
      private set => this.RaiseAndSetIfChanged(ref currentViewModel, value);
    }

    public ICommand NavigateCommand { get; }

    private void NavigateTo(string key)
    {
      CurrentViewModel = ViewModelsAvailable[key];
    }
  }
}