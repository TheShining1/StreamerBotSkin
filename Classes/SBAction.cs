using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StreamerBotSkin.Views.MainWindow;

namespace StreamerBotSkin.Classes
{
    public class SBAction
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string? Queue { get; set; }
        public string? Group { get; set; }
        public bool ExcludedFromHistory { get; set; }
        public bool AlwaysRun { get; set; }
        public bool RandomAction { get; set; }
        public bool Concurrent { get; set; }
        public string Options
        {
            get {
                var opt = new List<string>();

                if (this.ExcludedFromHistory) opt.Add("EX");
                if (this.AlwaysRun) opt.Add("AR");
                if (this.RandomAction) opt.Add("RA");
                if (this.Concurrent) opt.Add("CC");

                return opt.Count == 0 ? "None" : String.Join(", ", opt);
            }
        }
        List<SBSubAction> SBSubActions { get; set; }
        List<String> SubActionsGroups { get; set; }
        List<String> CollapsedSubActionsGroups { get; set; }

        public static ObservableCollection<SBAction> GetAll()
        {
            return new ObservableCollection<SBAction>(){
                new SBAction() { ID = 0, Name = "action0", Enabled = true, Queue=null, ExcludedFromHistory = true, Group = null, AlwaysRun = false, RandomAction = false, Concurrent = false, SBSubActions = new List<SBSubAction>() },
                new SBAction() { ID = 1, Name = "action1", Enabled = true, Queue="soundalerts", ExcludedFromHistory = false, Group = null, AlwaysRun = true, RandomAction = false, Concurrent = false, SBSubActions = new List<SBSubAction>() },
                new SBAction() { ID = 2, Name = "action2", Enabled = true, Queue="game", ExcludedFromHistory = false, Group = null, AlwaysRun = false, RandomAction = true, Concurrent = false, SBSubActions = new List<SBSubAction>() },
                new SBAction() { ID = 3, Name = "action3", Enabled = true, Queue="chat", ExcludedFromHistory = false, Group = null, AlwaysRun = false, RandomAction = false, Concurrent = true, SBSubActions = new List<SBSubAction>() },
                new SBAction() { ID = 3, Name = "action4", Enabled = true, Queue="chat", ExcludedFromHistory = false, Group = null, AlwaysRun = false, RandomAction = false, Concurrent = false, SBSubActions = new List<SBSubAction>() }
            };
        }
    }
}
