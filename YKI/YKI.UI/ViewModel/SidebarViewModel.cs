using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using YKI.UI.Enums;

namespace YKI.UI.ViewModel
{
    public class SidebarViewModel : ViewModelBase
    {
        private TabType _selectedTab;
        public TabType SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (_selectedTab != value)
                {
                    _selectedTab = value;
                    OnPropertyChanged(nameof(SelectedTab));
                    // Notify all visibility properties when tab changes  
                    OnPropertyChanged(nameof(IsMissionTabSelected));
                    OnPropertyChanged(nameof(IsTelemetryTabSelected));
                    OnPropertyChanged(nameof(IsVideoTabSelected));
                    OnPropertyChanged(nameof(IsSettingsTabSelected));
                }
            }
        }

        // Visibility properties for each tab  
        public bool IsMissionTabSelected => SelectedTab == TabType.Mission;
        public bool IsTelemetryTabSelected => SelectedTab == TabType.Telemetry;
        public bool IsVideoTabSelected => SelectedTab == TabType.Video;
        public bool IsSettingsTabSelected => SelectedTab == TabType.Settings;

        public SidebarViewModel()
        {
            // Default  
            SelectedTab = TabType.Mission;
        }

        // Method to update selected tab from external sources (like Taskbar)  
        public void UpdateSelectedTab(TabType tabType)
        {
            SelectedTab = tabType;
        }
    }
}