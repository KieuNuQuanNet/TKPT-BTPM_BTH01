using DPM225404_DO_QUOC_BAO_Myreal01_Mediator;
using System;
using System.Collections.Generic;

namespace Mediator.Airport
{
    /// <summary>
    /// Mediator Design Pattern - Airport Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo tháp điều khiển
            ControlTower tower = new ControlTower();

            // Tạo các máy bay
            Aircraft airbus = new PassengerAircraft("Airbus A320");
            Aircraft boeing = new PassengerAircraft("Boeing 737");
            Aircraft f16 = new MilitaryAircraft("F-16");

            // Đăng ký máy bay vào tháp điều khiển
            tower.Register(airbus);
            tower.Register(boeing);
            tower.Register(f16);

            // Giao tiếp qua tháp điều khiển
            airbus.Send("Boeing 737", "Xin chào Boeing, bạn bay ở độ cao nào?");
            boeing.Send("Airbus A320", "Tôi ở 30,000 feet, bạn thì sao?");
            f16.Send("Airbus A320", "Đây là F-16, chuẩn bị bay qua khu vực của bạn!");

            Console.ReadKey();
        }
    }
}