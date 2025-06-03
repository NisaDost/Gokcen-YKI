using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using YKI.UI.ViewModel;

namespace YKI.UI.View
{
    /// <summary>
    /// Interaction logic for HomePageView.xaml
    /// </summary>
    public partial class HomePageView : UserControl
    {
        public HomePageViewModel ViewModel { get; private set; }

        public HomePageView()
        {
            InitializeComponent();
            ViewModel = new HomePageViewModel();
            DataContext = ViewModel;

            Loaded += HomePageView_Loaded;
        }

        private void HomePageView_Loaded(object sender, RoutedEventArgs e)
        {
            // Set DataContext for nested components (Taskbar & Sidebar)
            var taskbar = FindChild<Components.Taskbar>(this);
            var sidebar = FindChild<Components.Sidebar>(this);

            if (taskbar != null)
                taskbar.DataContext = ViewModel.TaskbarViewModel;

            if (sidebar != null)
                sidebar.DataContext = ViewModel.SidebarViewModel;

            // Load MapPage.html into WebView2
            try
            {
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "MapPage.html");
                if (File.Exists(htmlPath))
                {
                    Uri htmlUri = new Uri(htmlPath);
                    MapWebView.Source = htmlUri;
                }
                else
                {
                    MessageBox.Show($"MapPage.html not found at: {htmlPath}", "File Not Found", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading MapPage.html: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Recursive visual tree search utility
        private static T FindChild<T>(DependencyObject parent) where T : DependencyObject
        {
            if (parent == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T typedChild)
                    return typedChild;

                var result = FindChild<T>(child);
                if (result != null)
                    return result;
            }

            return null;
        }
    }
}
