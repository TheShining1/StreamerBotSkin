using Avalonia.Controls;

namespace StreamerBotSkin.Controls
{
    public partial class MainCarousel : UserControl
    {
        public MainCarousel()
        {
            InitializeComponent();

            PageCarousel = this.Get<Carousel>(nameof(PageCarousel));
        }
    }
}
