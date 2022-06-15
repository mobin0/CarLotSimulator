using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> cars = new List<Car>();
        public static int numberOfCars;
        public static List<Car> staticParkingLot = new List<Car>();
        public void AddCar(Car c) {
            cars.Add(c);
        }
        public void PrintInfo() {
            foreach (Car i in cars) {
                Console.WriteLine($"{i.Year} {i.Make} {i.Model} ");
            
            }
        }

        }

}
