using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Collections;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  public class CommandsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;

    public DataGridCollectionView commandsItems { get; set; } = LoadCommands();

    public static DataGridCollectionView LoadCommands()
    {
      var commands = SBCommand.GetAll();
      var commandsCollectionView = new DataGridCollectionView(commands);
      commandsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

      return commandsCollectionView;
    }
  }
}
