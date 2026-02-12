using System;

namespace Lab6_Vehicles
{
    // Абстрактний базовий клас
    abstract class Vehicle
    {
        protected string brand;
        protected int speed;

        public Vehicle(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        // Абстрактний метод руху
        public abstract void Move();
    }
}
using System;

namespace Lab6_Vehicles
{
    class Car : Vehicle, IRefuelable
    {
        public Car(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Автомобіль {brand} рухається дорогою зі швидкістю {speed} км/год.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Автомобіль {brand} заправляється пальним.");
        }
    }
}
using System;

namespace Lab6_Vehicles
{
    class Bicycle : Vehicle
    {
        public Bicycle(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Велосипед {brand} рухається зі швидкістю {speed} км/год.");
        }
    }
}
using System;

namespace Lab6_Vehicles
{
    class Airplane : Vehicle, IRefuelable
    {
        public Airplane(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Літак {brand} летить зі швидкістю {speed} км/год.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Літак {brand} заправляється авіаційним паливом.");
        }
    }
}
namespace Lab6_Vehicles
{
    // Інтерфейс для заправки
    interface IRefuelable
    {
        void Refuel();
    }
}
using System;
using System.Collections.Generic;

namespace Lab6_Vehicles
{
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Toyota", 120),
                new Bicycle("Giant", 25),
                new Airplane("Boeing", 900)
            };

            Console.WriteLine("Демонстрація руху транспортних засобів:\n");

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();

                // Перевірка на інтерфейс
                if (vehicle is IRefuelable refuelable)
                {
                    refuelable.Refuel();
                }

                Console.WriteLine();
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

