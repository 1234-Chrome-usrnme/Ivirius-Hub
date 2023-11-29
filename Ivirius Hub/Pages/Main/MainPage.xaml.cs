using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Management.Deployment;
using Windows.Services.Store;
using Windows.Storage.Streams;
using Windows.System;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.AppService;
using Microsoft.Toolkit.Uwp.UI.Helpers;
using Microsoft.UI.Xaml.Controls;
using Ivirius_Hub.Pages.Ivirius.UI;
using Ivirius_Hub.Pages.CrimsonUI;

namespace Ivirius_Hub
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            var TB = ApplicationView.GetForCurrentView().TitleBar;
            var CTB = CoreApplication.GetCurrentView().TitleBar;
            TB.ButtonHoverBackgroundColor = Colors.White;
            TB.ButtonHoverForegroundColor = Colors.Black;
            TB.ButtonBackgroundColor = Colors.Transparent;
            TB.ButtonPressedBackgroundColor = Colors.WhiteSmoke;
            TB.ButtonPressedForegroundColor = Colors.Black;
            TB.ButtonInactiveBackgroundColor = Colors.Transparent;
            TB.ButtonInactiveForegroundColor = Color.FromArgb(1, 3, 165, 252);
            CTB.ExtendViewIntoTitleBar = true;
            NavView.SelectedItem = HomeItem;
            var TL = new ThemeListener();
            if (TL.CurrentTheme == ApplicationTheme.Light)
            {
                //ABrush.TintColor = Colors.White;
                //ABrush.FallbackColor = Colors.White;
            }
            else if (TL.CurrentTheme == ApplicationTheme.Dark)
            {
                //ABrush.TintColor = Colors.Black;
                //ABrush.FallbackColor = Colors.Black;
            }
            CTB.LayoutMetricsChanged += CTB_LayoutMetricsChanged;
        }

        private void CTB_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            UpdateTitleBarLayout(sender);
        }

        private void UpdateTitleBarLayout(CoreApplicationViewTitleBar coreTitleBar)
        {

        }

        private void NavigationView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            var frame = new Frame();
            NavView.Content = frame;
            if (args.SelectedItem == HomeItem)
            {
                frame.Navigate(typeof(HomePage));
            }
            if (args.SelectedItem == AboutItem)
            {
                frame.Navigate(typeof(AboutPage));
            }
            if (args.SelectedItem == IVRItem)
            {
                frame.Navigate(typeof(IviriusTextEditor));
            }
            if (args.SelectedItem == IVRPlusItem)
            {
                frame.Navigate(typeof(IviriusTextEditorPlus));
            }
            if (args.SelectedItem == IVRNotesItem)
            {
                frame.Navigate(typeof(IviriusNotes));
            }
            if (args.SelectedItem == WebItem)
            {
                frame.Navigate(typeof(OfflineWebsite));
            }
            if (args.SelectedItem == WindowingItem)
            {
                frame.Navigate(typeof(WindowingPage));
            }
            if (args.SelectedItem == IVRUIWin1Item)
            {
                frame.Navigate(typeof(ChildAppWindowShowcase));
            }
            if (args.SelectedItem == BtnItem)
            {
                frame.Navigate(typeof(ButtonCUI));
            }
        }
    }
}