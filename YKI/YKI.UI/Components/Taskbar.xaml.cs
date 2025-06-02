using System.Windows.Controls;
using YKI.UI.ViewModel;

namespace YKI.UI.Components
{
    public partial class Taskbar : UserControl
    {
        public TaskbarViewModel ViewModel { get; private set; }
        public Taskbar()
        {
            InitializeComponent();
            ViewModel = new TaskbarViewModel();
            DataContext = ViewModel;
        }
    }
}
