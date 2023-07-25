using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;
using Material.Dialog;
using ReactiveUI;
using StreamerBotSkin.Dialogs;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            StateModel = new State();
        }

        public State StateModel;

        public ICommand ChangeThemeCommand { get; }

        //public void AboutDialog_Open()
        //{
        //    var dialog = new AboutDialog();
        //    dialog.Width = Program.MainWindow.Width * 0.9;
        //    dialog.ShowDialog(Program.MainWindow);
        //}

    }
}