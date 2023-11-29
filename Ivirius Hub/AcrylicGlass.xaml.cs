using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Ivirius_Hub
{
    public sealed partial class AcrylicGlass : Page
    {
        public AcrylicGlass()
        {
            InitializeComponent();
            var AB = new AcrylicBrush();
            AB.TintColor = Colors.Transparent;
            AB.BackgroundSource = AcrylicBackgroundSource.HostBackdrop;
            AB.TintOpacity = 0.01;
            AB.FallbackColor = Colors.Transparent;
            MainPageComponent.Background = AB;
            RequestedTheme = ElementTheme.Light;
            AeroBlue.Visibility = Visibility.Visible;
            ToolbarTextAccent.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DetailsBlock.Visibility == Visibility.Visible)
            {
                DetailsBlock.Visibility = Visibility.Collapsed;
            }
            else
            {
                DetailsBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
