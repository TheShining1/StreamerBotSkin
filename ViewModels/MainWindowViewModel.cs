using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows.Input;
using Avalonia;
using Avalonia.Themes.Fluent;
using ReactiveUI;

namespace StreamerBotSkin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
        }

        public ICommand ChangeThemeCommand { get; }

    }
}