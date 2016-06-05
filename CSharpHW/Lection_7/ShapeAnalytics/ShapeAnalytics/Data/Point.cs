using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAnalytics.Data
{
    public class Point
    {
        public double XCoordinate { get; set; }

        public double YCoordinate { get; set; }

        public Point(double xCoordinate, double yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }
    }
}
