using ReactiveUI;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace StreamerBotSkin.ViewModels
{
  public abstract class ViewModelBase : ReactiveObject
  {
    public virtual string Name { get; set; }

    protected virtual void SetProperty<T>(ref T member, T val,
        [CallerMemberName] string propertyName = null)
    {
      if (object.Equals(member, val)) return;
      member = val;
      PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged = delegate { };
  }

  public class TabItemModel
  {
    public string Header { get; set; }
    public ViewModelBase ViewModel { get; set; }
  }
}