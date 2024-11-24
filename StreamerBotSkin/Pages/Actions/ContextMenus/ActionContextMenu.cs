using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Controls;

namespace StreamerBotSkin.ContextMenus
{
  internal class ActionContextMenu : ContextMenu
  {
    public ActionContextMenu()
    {
      ItemsSource = new List<MenuItem>{
        new MenuItem { Header= "Add" },
        new MenuItem { Header= "Edit" },
        new MenuItem { Header= "Delete" }
       };
    }
  }
}
