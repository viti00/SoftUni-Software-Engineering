using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model , string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public int Battery
        {
            get => battery;
            set => battery = value;
        }

        public void Start()
        {
            Console.WriteLine("Engine start");
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }


        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries";
        }
    }
}
