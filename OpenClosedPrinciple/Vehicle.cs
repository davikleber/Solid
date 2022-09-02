using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Vehicle
    {
        protected string color;
        protected int year;
        protected double engine;
        protected int seats;
        protected int doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} acentos");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilindradas. ");
            StartVehicle();
        }
        public void StartVehicle()
        {
            Console.WriteLine("ligando os motores");
        }
    }
}
