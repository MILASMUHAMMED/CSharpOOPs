using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Encapsulation
    {
        private double length;
        private double width;
        private double height;

        public Encapsulation(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string SurfaceArea()
        {
            double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;
            return $"Surface Area - {surfaceArea:F2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.length * this.height) + 2 * (this.width * this.height);
            return $"Lateral Surface Area - {lateralSurfaceArea:F2}";
        }

        public string Volume()
        {
            double volume = this.length * this.width * this.height;
            return $"Volume - {volume:F2}";
        }
    }
}
