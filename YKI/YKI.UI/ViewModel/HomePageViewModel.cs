﻿using System.IO;
using System.Windows.Input;
using Microsoft.Web.WebView2.Wpf;
using YKI.Service.Logging;
using YKI.Service.ROS;
using YKI.UI.Command;
using System.Globalization;

namespace YKI.UI.ViewModel
{
    public class HomePageViewModel : ViewModelBase
    {
        private string _latitude = "39.9255";  // Default center latitude (Ankara, Türkiye) - stored as string for textbox usage
        private string _longitude = "32.8663"; // Default center longitude (Ankara, Türkiye) - stored as string for textbox usage
        private string _mapUrl;

        // Shared ViewModels that will be used by the UI components
        public TaskbarViewModel TaskbarViewModel { get; private set; }
        public SidebarViewModel SidebarViewModel { get; private set; }

        public ICommand UpdateMapCommand { get; }
        public ICommand LogDenemeCommand { get; }

        public HomePageViewModel()
        {
            string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory).Split("bin")[0];
            _mapUrl = Path.Combine(relativePath, "Resources", "MapPage.html");

            UpdateMapCommand = new RelayCommand(UpdateMap);
            LogDenemeCommand = new RelayCommand(LogDeneme);

            // Initialize shared ViewModels
            TaskbarViewModel = new TaskbarViewModel();
            SidebarViewModel = new SidebarViewModel();

            // Set up communication between Taskbar and Sidebar
            TaskbarViewModel.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(TaskbarViewModel.SelectedTab))
                {
                    SidebarViewModel.UpdateSelectedTab(TaskbarViewModel.SelectedTab);
                }
            };

            // Initialize services
            LoggingService.Init();
            //RosNodeService rosNodeService = new RosNodeService();
            //rosNodeService.Init();
        }

        public string Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged(nameof(Latitude));
            }
        }

        public string Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }

        public string MapUrl
        {
            get { return _mapUrl; }
            set
            {
                _mapUrl = value;
                OnPropertyChanged("MapUrl");
            }
        }

        private void UpdateMap()
        {
            if (WebViewInstance == null)
                return;

            WebViewInstance.NavigationCompleted += (s, e) =>
            {
                if (double.TryParse(Latitude, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat) &&
                    double.TryParse(Longitude, NumberStyles.Float, CultureInfo.InvariantCulture, out double lng))
                {
                    string latStr = lat.ToString(CultureInfo.InvariantCulture);
                    string lngStr = lng.ToString(CultureInfo.InvariantCulture);

                    string script = $"map.setView([{latStr}, {lngStr}], 15);";
                    WebViewInstance.ExecuteScriptAsync(script);
                }
            };
        }


        private void LogDeneme()
        {
            LoggingService.Info("Deneme Info");
            LoggingService.Warn("Deneme Warn");
            LoggingService.Error("Deneme Error");
            LoggingService.Trace("Deneme Trace");
        }

        private WebView2 _webViewInstance;
        public WebView2 WebViewInstance
        {
            get => _webViewInstance;
            set
            {
                _webViewInstance = value;
                OnPropertyChanged(nameof(WebViewInstance));
            }
        }
    }
}