namespace StreamerBotSkin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        public int CurrentView { get; set; }
    }
}