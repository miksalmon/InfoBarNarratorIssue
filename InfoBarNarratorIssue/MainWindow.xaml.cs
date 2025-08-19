using System;
using Microsoft.UI.Xaml.Input;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace InfoBarNarratorIssue
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavFrame.Navigated += NavFrame_Navigated;
            NavFrame.Navigate(typeof(Page1));
        }

        private void NavFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.SourcePageType == typeof(Page2))
            {
                IsOpenCheckBox1.IsChecked = true;
            }
            else
            {
                IsOpenCheckBox1.IsChecked = false;
            }
        }

        private void NavView_SelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
        {
            if (e.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "page1":
                        NavFrame.Navigate(typeof(Page1));
                        break;
                    case "page2":
                        NavFrame.Navigate(typeof(Page2));
                        break;
                }
            }
        }
    }
}
