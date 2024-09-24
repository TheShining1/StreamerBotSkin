using ReactiveUI;

using StreamerBotSkin.Dialogs;

using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace StreamerBotSkin.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    public MainWindowViewModel()
    {
      currentViewModel = ViewModelsAvailable["midi"];

      NavigateCommand = ReactiveCommand.Create<string>(NavigateTo);
      OpenAboutCommand = ReactiveCommand.Create(OpenAboutDialog);
    }

    private readonly Dictionary<string, ViewModelBase> ViewModelsAvailable = new()
    {
      {"main", new MainViewModel() },
      {"viewers", new ViewersViewModel() },
      {"actions", new ActionsViewModel() },
      {"queues", new ActionQueuesViewModel() },
      {"commands", new CommandsViewModel() },
      {"midi", new MidiViewModel() },
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

    public ICommand OpenAboutCommand { get; }

    private void OpenAboutDialog()
    {
      if (Program.MainWindow == null) return;
      var dialog = new AboutDialog();
      dialog.Width = Program.MainWindow.Width * 0.9;
      dialog.ShowDialog(Program.MainWindow);
    }
  }
}