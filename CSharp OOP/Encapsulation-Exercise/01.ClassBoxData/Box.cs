using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        private double Lenght
        {
            get
            {
                return this.lenght;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }

                this.lenght = value;
            }
        }
        private double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        private double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double area = 2 * (this.Lenght * this.Width) +
                2 * (this.Lenght * this.Height) +
                2 * (this.Width * this.Height);
            return area;
        }
        public double LateralSurfaceArea()
        {
            double lateralArea = (2 * this.Lenght * this.Height) +
                (2 * this.Width * this.Height);
            return lateralArea;
        }

        public double Volume()
        {
            double volume = this.Width * this.Lenght * this.Height;
            return volume;
        }
    }
}
