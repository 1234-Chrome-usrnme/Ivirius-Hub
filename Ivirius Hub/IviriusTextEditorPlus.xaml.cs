using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ivirius_Hub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IviriusTextEditorPlus : Page
    {
        public IviriusTextEditorPlus()
        {
            this.InitializeComponent();
        }


        private async void Button_Click_8(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("ivirius-ivreditorplus:"));
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ivirius-ivreditorplus.showhelpbuttons://"));
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ivirius-ivreditorplus.beginhelpsession://"));
        }

        private async void Button_Click_7(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ivirius-ivreditorplus.handwriting://"));
        }

        private async void Button_Click_9(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://pdp/?productid=9N4T9H9182J5"));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }
    }
}
