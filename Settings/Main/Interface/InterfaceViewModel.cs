using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  internal class InterfaceViewModel: ViewModelBase
  {
    public List<SBSubActionsList> SubActions { get; set; } = SBSubActionsList.GetAll();
  }
}
