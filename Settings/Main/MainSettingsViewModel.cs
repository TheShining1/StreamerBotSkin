using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Microsoft.VisualBasic;

using ReactiveUI;

using StreamerBotSkin.ViewModels;

using Windows.Foundation.Diagnostics;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System.Collections.ObjectModel;

namespace StreamerBotSkin.ViewModels
{
  public class MainSettingsViewModel : ViewModelBase
  {
    public MainSettingsViewModel()
    {

    }

    public ObservableCollection<TabItemModel> MainSettingsViewModelsAvailable { get; set; } = new ObservableCollection<TabItemModel>
      {
        new TabItemModel{ Header = "General", ViewModel = new GeneralViewModel() },
        new TabItemModel{ Header = "Interface", ViewModel = new InterfaceViewModel() },
        new TabItemModel{ Header = "Audio", ViewModel = new AudioViewModel() },
        new TabItemModel{ Header = "Compiler", ViewModel = new CompilerViewModel() },
        new TabItemModel{ Header = "Labs", ViewModel = new LabsViewModel() }
      };
  }
}