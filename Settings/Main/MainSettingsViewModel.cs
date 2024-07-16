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

namespace StreamerBotSkin.ViewModels
{
    public class MainSettingsViewModel : ViewModelBase
    {
      public MainSettingsViewModel()
      {
    
      }

      public List<ViewModelBase> MainSettingsViewModelsAvailable { get; } = new List<ViewModelBase>
      {
        { new GeneralViewModel() },
        { new InterfaceViewModel() },
        { new AudioViewModel() },
        { new CompilerViewModel() },
        { new LabsViewModel() }
      };
  }
}
