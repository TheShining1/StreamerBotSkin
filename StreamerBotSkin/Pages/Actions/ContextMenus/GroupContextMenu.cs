using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Controls;

namespace StreamerBotSkin.ContextMenus
{
  internal class GroupContextMenu : ContextMenu
  {
    public GroupContextMenu()
    {
      ItemsSource = new List<MenuItem>{
        new MenuItem { Header= "Expand all" },
        new MenuItem { Header= "Collapse all" }
       };
    }
  }
}
