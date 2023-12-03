using Microsoft.Toolkit.Uwp.UI.Helpers;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ivirius_Hub.Pages.CrimsonUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RevealFocus : Page
    {
        public RevealFocus()
        {
            this.InitializeComponent();
            var x = new ThemeListener();
            if (x.CurrentTheme == ApplicationTheme.Light) ItemsViewer.RequestedTheme = ElementTheme.Light;
            else ItemsViewer.RequestedTheme = ElementTheme.Dark;
            if (Application.Current.FocusVisualKind == FocusVisualKind.HighVisibility)
            {
                HighVisibilityrb.IsChecked = true;
            }
            else
            {
                RevealFocusrb.IsChecked = true;
            }
            xaml.Text = @"<controls:RadioButtons Header=""FocusVisualKind:"" FontWeight=""SemiBold"">
                    <RadioButton x:Name = ""HighVisibilityrb"" Content = ""High Visibility"" Checked = ""HighVisibility_Checked"" />
                    <RadioButton x:Name = ""RevealFocusrb"" Content = ""Reveal Focus""  Checked = ""RevealFocus_Checked"" />
                </ controls:RadioButtons >";
            CSharp.Text = @"if (Application.Current.FocusVisualKind == FocusVisualKind.HighVisibility)
            {
                HighVisibilityrb.IsChecked = true;
            }
            else
            {
                RevealFocusrb.IsChecked = true;
            }

private void HighVisibility_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.FocusVisualKind = FocusVisualKind.HighVisibility;
        }

        private void RevealFocus_Checked(object sender, RoutedEventArgs e)
        {
                Application.Current.FocusVisualKind = FocusVisualKind.Reveal;
        }";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsViewer.RequestedTheme == ElementTheme.Dark) ItemsViewer.RequestedTheme = ElementTheme.Light;
            else ItemsViewer.RequestedTheme = ElementTheme.Dark;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window.Current.Content as Frame).Content as MainPage).NavigateToStore();
        }

        private void HighVisibility_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.FocusVisualKind = FocusVisualKind.HighVisibility;
        }

        private void RevealFocus_Checked(object sender, RoutedEventArgs e)
        {
                Application.Current.FocusVisualKind = FocusVisualKind.Reveal;
        }
    }
}
