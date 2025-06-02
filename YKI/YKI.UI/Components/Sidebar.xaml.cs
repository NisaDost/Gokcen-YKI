using System.Windows.Controls;
using YKI.UI.ViewModel;

namespace YKI.UI.Components
{
    public partial class Sidebar : UserControl
    {
        public SidebarViewModel ViewModel { get; private set; }

        public Sidebar()
        {
            InitializeComponent();
            ViewModel = new SidebarViewModel();
            DataContext = ViewModel;
        }
    }
}