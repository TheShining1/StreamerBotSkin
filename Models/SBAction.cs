using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Avalonia.Collections;

using Newtonsoft.Json;

namespace StreamerBotSkin.Models
{
  public class SBAction
  {
    public string ID { get; set; }
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
      get
      {
        var opt = new List<string>();

        if (this.ExcludedFromHistory) opt.Add("EX");
        if (this.AlwaysRun) opt.Add("AR");
        if (this.RandomAction) opt.Add("RA");
        if (this.Concurrent) opt.Add("CC");

        return opt.Count == 0 ? "None" : String.Join(", ", opt);
      }
    }

    public List<SBTrigger> Triggers { get; set; } = new List<SBTrigger> { };

    //public int TriggersCout
    //{
    //  get
    //  {
    //    return Triggers.Count;
    //  }
    //}
    public List<SBSubAction> Actions { get; set; } = new List<SBSubAction> { };
    List<String> ActionGroups { get; set; } = new List<String> { };
    List<String> CollapsedGroups { get; set; } = new List<String> { };
    //public static ObservableCollection<SBAction> GetAll()
    //{
    //    return new ObservableCollection<SBAction>(){
    //        new SBAction() { ID = "0", Name = "action0", Enabled = true, Queue=null, ExcludedFromHistory = true, Group = null, AlwaysRun = false, RandomAction = false, Concurrent = false, Actions = new List<SBSubAction>(), Triggers = new List<SBTrigger>() },
    //        new SBAction() { ID = "1", Name = "action2", Enabled = true, Queue="0", ExcludedFromHistory = false, Group = null, AlwaysRun = true, RandomAction = false, Concurrent = false, Actions = new List<SBSubAction>(), Triggers = new List<SBTrigger>() },
    //        new SBAction() { ID = "2", Name = "action4", Enabled = true, Queue="1", ExcludedFromHistory = false, Group = "games", AlwaysRun = false, RandomAction = true, Concurrent = false, Actions = new List<SBSubAction>(), Triggers = new List<SBTrigger>() },
    //        new SBAction() { ID = "3", Name = "action1", Enabled = true, Queue="2", ExcludedFromHistory = false, Group = "games", AlwaysRun = false, RandomAction = false, Concurrent = true, Actions = new List<SBSubAction>(), Triggers = new List<SBTrigger>() },
    //        new SBAction() { ID = "3", Name = "action3", Enabled = true, Queue="3", ExcludedFromHistory = false, Group = "brb", AlwaysRun = false, RandomAction = false, Concurrent = false, Actions = new List<SBSubAction>(), Triggers = new List<SBTrigger>() }
    //    };
    //}

    public static ObservableCollection<SBAction> GetAll()
    {
      string actionsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "actions.json");
      return JsonConvert.DeserializeObject<ObservableCollection<SBAction>>(File.ReadAllText(actionsFilePath));
    }
  }
}
