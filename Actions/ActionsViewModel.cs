using System;
using System.Windows.Input;
using ReactiveUI;
using System.Collections.ObjectModel;
using StreamerBotSkin.Models;
using Avalonia.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StreamerBotSkin.ViewModels
{
    public class ActionsViewModel : ViewModelBase
    {
        public string ModelName { get; set; } = "ActionsViewModel";
        public DataGridCollectionView actionsItems { get; set; } = SBAction.GetAll();

        private SBAction _currentAction;

        public SBAction currentAction
        {
            get { return _currentAction; }
            set {                 
                this.RaiseAndSetIfChanged(ref _currentAction, value);
            }
        }
        private List<SBSubAction> _currentSubActions;
        public List<SBSubAction> currentSubActions
        {
            get { return _currentSubActions; }
            set { _currentSubActions = value; }
        }
    }
}