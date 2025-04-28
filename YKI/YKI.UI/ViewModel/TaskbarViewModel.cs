using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YKI.UI.Command;
using YKI.UI.Enums;

namespace YKI.UI.ViewModel
{
    public class TaskbarViewModel : ViewModelBase
    {
        private TabType _selectedTab = TabType.Mission;
        public TabType SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (_selectedTab != value)
                {
                    _selectedTab = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand MissionTabCommand { get; }
        public ICommand TelemetryTabCommand { get; }
        public ICommand VideoTabCommand { get; }
        public ICommand SettingsTabCommand { get; }

        public TaskbarViewModel()
        {
            MissionTabCommand = new RelayCommand(() => SelectedTab = TabType.Mission);
            TelemetryTabCommand = new RelayCommand(() => SelectedTab = TabType.Telemetry);
            VideoTabCommand = new RelayCommand(() => SelectedTab = TabType.Video);
            SettingsTabCommand = new RelayCommand(() => SelectedTab = TabType.Settings);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
