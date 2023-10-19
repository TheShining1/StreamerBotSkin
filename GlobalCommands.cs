using Avalonia.Controls;
using StreamerBotSkin.Controls;
using StreamerBotSkin.Controls.Settings;
using StreamerBotSkin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin
{
    public static class GlobalCommands
    {
        public static MainCarousel mainCarousel = new MainCarousel();
        public static MainDrawer mainDrawer = new MainDrawer();
        public static MainBarMenu mainBarMenu = new MainBarMenu();
        
        public static SettingsMenu settingsMenu = new SettingsMenu();
        public static Carousel SettingsCarousel = new Carousel();
    }
}
