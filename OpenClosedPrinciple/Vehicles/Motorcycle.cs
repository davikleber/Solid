﻿using System;


namespace OpenClosedPrinciple.Vehicles
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorCycle();
        }

        public void ConfigureMotorCycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilindradas. ");
            StartVehicle();
        }
    }
}
