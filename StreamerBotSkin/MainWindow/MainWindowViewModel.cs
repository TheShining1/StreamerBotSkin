using ReactiveUI;

using StreamerBotSkin.Dialogs;

using System;
using System.Collections.Generic;
using System.Windows.Input;

using StreamerBotSkin.Models;
using System.Linq;

namespace StreamerBotSkin.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    public MainWindowViewModel()
    {
      ViewModelsAvailable = new Dictionary<string, ViewModelBase>();

      foreach(var item in MainDrawerMenuItems)
      {
        if (item.CommandParameter == null) continue;
        ViewModelsAvailable[item.CommandParameter] = item.ViewModel;
      }

      currentViewModel = ViewModelsAvailable["viewers"];

      NavigateCommand = ReactiveCommand.Create<string>(NavigateTo);
      OpenAboutCommand = ReactiveCommand.Create(OpenAboutDialog);
    }

    private bool isMainDrawerOpen;
    public bool IsMainDrawerOpen {
      get => isMainDrawerOpen;
      set => this.RaiseAndSetIfChanged(ref isMainDrawerOpen, value);
    }

    public List<MainDrawerMenuItem> MainDrawerMenuItems { get; } = new()
    {
      new(){
        Label="Viewers",
        CommandParameter="viewers",
        ViewModel=new ViewersViewModel()
      },
      new(){
        Label="Actions",
        CommandParameter="actions",
        ViewModel=new ActionsViewModel()
      },
      new(){
        Label="Queues",
        CommandParameter="queues",
        ViewModel=new ActionQueuesViewModel()
      },
      new(){
        Label="Commands",
        CommandParameter="commands",
        ViewModel=new CommandsViewModel()
      },
      new(){
        Label="Midi",
        CommandParameter="midi",
        ViewModel=new MidiViewModel()
      },
      new(){
        Label="Voice Control",
        CommandParameter="voicecontrol",
        ViewModel=new VoiceControlViewModel()
      },
      new(){
        Label="Hotkeys",
        CommandParameter="hotkeys",
        ViewModel=new HotKeysViewModel()
      },
      new(){
        Label="Servers",
        CommandParameter="servers",
        ViewModel=new ServersViewModel()
      }
    };

    private Dictionary<string, ViewModelBase> ViewModelsAvailable = new();
    //{
    //  //{"main", new MainViewModel() },
    //  {"viewers", new ViewersViewModel() },
    //  {"actions", new ActionsViewModel() },
    //  {"queues", new ActionQueuesViewModel() },
    //  {"commands", new CommandsViewModel() },
    //  {"midi", new MidiViewModel() },
    //  {"voicecontrol", new VoiceControlViewModel() },
    //  {"hotkeys", new HotKeysViewModel() },
    //  {"servers", new ServersViewModel() },
    //  {"cpr", new ChannelPointRewardsViewModel() },
    //  {"polls", new PollsViewModel() },
    //  {"predictions", new PredictionsViewModel() },
    //  {"settings", new SettingsViewModel() }
    //};

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
      IsMainDrawerOpen = false;
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