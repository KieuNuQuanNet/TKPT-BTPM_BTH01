using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreak01_Obsetver
{
    public class MobileApp : IObserver
    {
        private string appName;

        public MobileApp(string appName)
        {
            this.appName = appName;
        }

        public void Update(Subject subject)
        {
            if (subject is WeatherStation station)
            {
                Console.WriteLine("📱 {0} nhận thông báo: {1} có nhiệt độ {2}°C",
                    appName, station.Name, station.Temperature);
            }
        }
    }
    public class Website : IObserver
    {
        private string siteName;

        public Website(string siteName)
        {
            this.siteName = siteName;
        }

        public void Update(Subject subject)
        {
            if (subject is WeatherStation station)
            {
                Console.WriteLine("🌐 {0} cập nhật: {1} đang {2}°C",
                    siteName, station.Name, station.Temperature);
            }
        }
    }
}

