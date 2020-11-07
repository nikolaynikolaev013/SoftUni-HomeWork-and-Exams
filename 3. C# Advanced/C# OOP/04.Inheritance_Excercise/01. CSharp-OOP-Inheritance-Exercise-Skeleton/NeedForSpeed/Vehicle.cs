﻿using System;
namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            var fuelAfterTrip = this.Fuel - kilometers * FuelConsumption;

            if (fuelAfterTrip >= 0)
            {
                this.Fuel -= kilometers * FuelConsumption;
            }
        }
    }
}
