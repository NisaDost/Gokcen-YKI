using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

            // Set the DataContext for the Taskbar and Sidebar to use the shared ViewModels
            // This assumes you have named your components in XAML or you can access them by type
            Loaded += HomePageView_Loaded;
        }

        private void HomePageView_Loaded(object sender, RoutedEventArgs e)
        {
            // Find the Taskbar and Sidebar components and set their DataContext
            var taskbar = FindChild<Components.Taskbar>(this);
            var sidebar = FindChild<Components.Sidebar>(this);

            if (taskbar != null)
            {
                taskbar.DataContext = ViewModel.TaskbarViewModel;
            }

            if (sidebar != null)
            {
                sidebar.DataContext = ViewModel.SidebarViewModel;
            }
        }

        // Helper method to find child controls of a specific type
        private static T FindChild<T>(DependencyObject parent) where T : DependencyObject
        {
            if (parent == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T result)
                    return result;

                var childOfChild = FindChild<T>(child);
                if (childOfChild != null)
                    return childOfChild;
            }
            return null;
        }
    }
}