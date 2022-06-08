using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        public void setProperties(string make, string model, int year, string enginenoise, string honknoise,bool isdriveable) {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.EngineNoise = enginenoise;
            this.HonkNoise = honknoise;
            this.IsDriveable = isdriveable;

        }
        public void MakeEngineNoise() {
            Console.WriteLine(this.EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(this.HonkNoise);
        }
    }
}
