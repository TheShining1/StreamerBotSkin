using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace StreamerBotSkin.ViewModels
{
  public class GeneralViewModel : ViewModelBase
  {
    public string Name { get; } = "General";

    //private string name = "General";
    //public string Name
    //{
    //  get => name;
    //  private set => this.RaiseAndSetIfChanged(ref name, value);
    //}
  }
}
