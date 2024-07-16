using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Microsoft.VisualBasic;

using ReactiveUI;

using Windows.Foundation.Diagnostics;

namespace StreamerBotSkin.ViewModels
{
    public class MainSettingsViewModel : ViewModelBase
    {
      public MainSettingsViewModel()
      {
      SelectedTab = "General";
      currentMainSettingsViewModel = MainSettingsViewModelsAvailable[SelectedTab];
      //_logLevels = Array.ForEach<typeof(LogLevel)>(Enum.GetValues(typeof(LogLevel)), l => new Dictionary<LogLevel, string>() { l, "Test" }).ToList();

      //logLevels = new Dictionary<int, string>()
      //{
      //  { 0, "Verbose" },
      //  { 1, "Dedug" },
      //  { 2, "Information" }
      //};


      logLevels = new List<string>()
      {
        { "Verbose" },
        { "Dedug" },
        { "Information" }
      };

      currentLogLevelIndex = 0;
      currentLogLevel = logLevels[currentLogLevelIndex];

      //_logLevels.Add(new Dictionary<int, string>{ { 0, "Verbose" } });
      //_logLevels.Add(new Dictionary<int, string>{ { 1, "Dedug" } });
      //_logLevels.Add(new Dictionary<int, string>{ { 2, "Information" } });

      //_currentLogLevel = _logLevels[0];
    }

    public List<string> Tabs { get; set; } = new List<string>()
    {
      "General",
      "Interface"
    };

    public string SelectedTab { get; set; } = "General";

    private readonly Dictionary<string, ViewModelBase> MainSettingsViewModelsAvailable = new Dictionary<string, ViewModelBase>
    {
      { "General", new GeneralViewModel() },
      { "Interface", new InterfaceViewModel() }
    };

    public ICommand NavigateMainSettingsCommand { get; }

    private void NavigateToMainSetting(string key)
    {
      CurrentMainSettingsViewModel = MainSettingsViewModelsAvailable[key];
    }

    private ViewModelBase currentMainSettingsViewModel;
    public ViewModelBase CurrentMainSettingsViewModel
    {
      get => currentMainSettingsViewModel;
      private set => this.RaiseAndSetIfChanged(ref currentMainSettingsViewModel, value);
    }

    //private Dictionary<int, string> logLevels { get; set; }
    private int currentLogLevelIndex { get; set; }
    private string currentLogLevel { get; set; }

    //public enum LogLevel
    //{
    //  Verbose,
    //  Dedug,
    //  Information
    //}

    public List<string> logLevels { get; set; } = new List<string>();
    //public Dictionary<int, string> logLevels { get; set; } = new Dictionary<int, string>();
    //public List<Dictionary<int, string>> _logLevels = new List<Dictionary<int, string>>()
    //{
    //  new Dictionary<int, string>(){ (int)LogLevel.Verbose, "Verbose" },
    //  new Dictionary<int, string>(){ (int)LogLevel.Dedug, "Dedug" },
    //  new Dictionary<int, string>(){ (int)LogLevel.Information, "Information" }
    //};

    //public KeyValuePair<int, string> _currentLogLevel = new KeyValuePair<int, string>(0, "Verbose");
    //public KeyValuePair<int, string> CurrentLogLevel { 
    //  get
    //  { 
    //    return _currentLogLevel;
    //  }
    //}
    //public string CurrentLogLevel
    //{
    //  get { 
    //    return _currentLogLevel;
    //  }
    //  set
    //  {
    //    this.RaiseAndSetIfChanged(ref _currentLogLevel, value);
    //  }
    //}
  }
}
