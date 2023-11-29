using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ivirius_Hub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://pdp/?productid=9MV281ZZF51P"));
            var uri = new Uri("ivirius-ivreditor:");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success != true)
            {

            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://pdp/?productid=9NTMTNVPMQF1"));
            var uri = new Uri("ivirius-ivrnotes:");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success != true)
            {

            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Window = await AppWindow.TryCreateAsync();
            Frame RF = new Frame();
            RF.Navigate(typeof(AcrylicGlass));
            ElementCompositionPreview.SetAppWindowContent(Window, RF);
            var AppTitleBar = Window.TitleBar;
            AppTitleBar.ExtendsContentIntoTitleBar = true;
            AppTitleBar.ButtonBackgroundColor = Colors.Transparent;
            AppTitleBar.ButtonForegroundColor = Colors.White;
            AppTitleBar.ButtonHoverForegroundColor = Colors.White;
            AppTitleBar.ButtonPressedForegroundColor = Colors.White;
            AppTitleBar.ButtonHoverBackgroundColor = Color.FromArgb(100, 79, 146, 255);
            AppTitleBar.ButtonPressedBackgroundColor = Color.FromArgb(100, 81, 117, 176);
            await Window.TryShowAsync();
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("ivirius-ivreditorplus:");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://ivirius.webnode.page/");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://www.youtube.com/channel/UC-wq6vlXEW3FBj2jMNVMOkg");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://ivirius.webnode.page/contact/");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }
    }
}
