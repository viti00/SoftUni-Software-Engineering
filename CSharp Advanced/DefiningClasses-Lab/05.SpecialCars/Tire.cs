using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {

        public int Year { get; set; }

        public double Pressure { get; set; }

        public List<int> GetYear (string[] splitted)
        {
            List<int> listYears = new List<int>();
            for (int i = 0; i < splitted.Length; i+= 2)
            {
                listYears.Add(int.Parse(splitted[i]));
            }
            return listYears;
        }

        public List<double> GetPressure (string[] splitted)
        {
            List<double> listPressure = new List<double>();
            for (int i = 1; i < splitted.Length; i+=2)
            {
                listPressure.Add(double.Parse(splitted[i]));
            }
            return listPressure;
        }

        public double GetPressureSum(List<List<double>> listTiresPressures,
            int tiresIndex)
        {
            double sum = listTiresPressures[tiresIndex].Sum();
            return sum;
        }

    }
}
