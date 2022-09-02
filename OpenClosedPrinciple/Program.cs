﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        //Código funcional
        //Alguns conceitos não está sendo aplicados incluse o (S)
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Vehicle vehicle = new Vehicle("Azul", 2022,2.0,5,4);
                vehicle.Car();
            }
            else
            {
                Vehicle vehicle = new Vehicle("Branco", 2023, 250, 1, 0);
                vehicle.Motorcycle();

            }
            Console.ReadLine();
        }
    }
}
