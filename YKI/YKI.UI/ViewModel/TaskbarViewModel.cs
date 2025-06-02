using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using YKI.UI.Command;
using YKI.UI.Enums;

namespace YKI.UI.ViewModel
{
    public class TaskbarViewModel : ViewModelBase
    {
        private TabType _selectedTab = TabType.Mission;
        private string _currentTime = DateTime.Now.ToString("HH:mm:ss");
        private string _connectionStatusText = "Bağlantısız";
        private SolidColorBrush _connectionStatusBrush = new SolidColorBrush(Colors.Red);

        public TabType SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (_selectedTab != value)
                {
                    _selectedTab = value;
                    OnPropertyChanged(nameof(SelectedTab));
                }
            }
        }

        public string CurrentTime
        {
            get => _currentTime;
            set
            {
                _currentTime = value;
                OnPropertyChanged(nameof(CurrentTime));
            }
        }

        public string ConnectionStatusText
        {
            get => _connectionStatusText;
            set
            {
                _connectionStatusText = value;
                OnPropertyChanged(nameof(ConnectionStatusText));
            }
        }

        public SolidColorBrush ConnectionStatusBrush
        {
            get => _connectionStatusBrush;
            set
            {
                _connectionStatusBrush = value;
                OnPropertyChanged(nameof(ConnectionStatusBrush));
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

            // Update time every second
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) => CurrentTime = DateTime.Now.ToString("HH:mm:ss");
            timer.Start();
        }
    }
}
