using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StreamerBotSkin.ViewModels;

namespace StreamerBotSkin.Models
{
  public class MainDrawerMenuItem
  {
    public string? Label { get; set; }
    public string? CommandParameter { get; set; }
    public ViewModelBase? ViewModel { get; set; }
  }
}
