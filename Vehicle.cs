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

