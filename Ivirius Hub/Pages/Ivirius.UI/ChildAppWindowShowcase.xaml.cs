using Ivirius.UI.Windowing;
using Microsoft.Toolkit.Uwp.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ivirius_Hub.Pages.Ivirius.UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChildAppWindowShowcase : Page
    {
        public ChildAppWindowShowcase()
        {
            InitializeComponent();
            var x = new ThemeListener();
            if (x.CurrentTheme == ApplicationTheme.Light) AppWin.RequestedTheme = ElementTheme.Light;
            else AppWin.RequestedTheme = ElementTheme.Dark;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AppWin.RequestedTheme == ElementTheme.Dark) AppWin.RequestedTheme = ElementTheme.Light;
            else AppWin.RequestedTheme = ElementTheme.Dark;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            AppWin.Open();
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            AppWin.Backdrop = ChildAppWindow.BackdropKind.Acrylic;
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            AppWin.Backdrop = ChildAppWindow.BackdropKind.Mica;
        }

        private void HyperlinkButton_Click_3(object sender, RoutedEventArgs e)
        {
            AppWin.Backdrop = ChildAppWindow.BackdropKind.MicaAlt;
        }
    }
}
