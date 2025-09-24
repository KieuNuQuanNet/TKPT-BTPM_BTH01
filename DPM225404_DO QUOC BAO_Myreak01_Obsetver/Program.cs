using DPM225404_DO_QUOC_BAO_Myreak01_Obsetver;
using System;
using System.Collections.Generic;


    public class Program
    {
        public static void Main(string[] args)
        {
        // Tạo WeatherStation và đăng ký observers
            WeatherStation station = new WeatherStation("Station A", 30.0);
            station.Attach(new MobileApp("App 1"));
            station.Attach(new MobileApp("App 2"));
            station.Attach(new Website("Weather.com"));

            // Thay đổi nhiệt độ -> Notify observers
            station.Temperature = 31.5;
            station.Temperature = 29.0;
            station.Temperature = 33.2;

            Console.ReadKey();
        }
    }
