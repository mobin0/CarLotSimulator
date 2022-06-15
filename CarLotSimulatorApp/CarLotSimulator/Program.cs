using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car NissanSamurai = new Car();
            Car ToyotaGalaxy = new Car();
            Car PorscheTarantula = new Car();
            CarLot Granduromo = new CarLot();
            Granduromo.AddCar(NissanSamurai);
            Granduromo.AddCar(ToyotaGalaxy);
            PorscheTarantula.setProperties("Porsche", "Tarantula", 2050, "swuuuuuuum", "BEEEEEEEEEEEP", true);
      
            Granduromo.AddCar(PorscheTarantula);
            NissanSamurai.setProperties("Nissan", "Samurai", 2030, "yyuyuyuyyuyu", "BEEEEHHHH", true);
            ToyotaGalaxy.setProperties("Toyota", "Galaxy", 2040, "rumrumrrum", "uwwuuwuw", true);
            NissanSamurai.MakeEngineNoise(); NissanSamurai.MakeHonkNoise();
            Console.WriteLine("Toyota Galaxy");
            ToyotaGalaxy.MakeEngineNoise(); ToyotaGalaxy.MakeHonkNoise();
            Console.WriteLine("Porsche Tarantula");
            PorscheTarantula.MakeEngineNoise(); PorscheTarantula.MakeHonkNoise();

            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Granduromo.PrintInfo();
        }
    }
}
