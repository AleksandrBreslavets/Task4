using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Mountain :IGeographicObject
    {
        private double _topPoint;
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Mountain(double x, double y, string name, string description, double topPoint)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            _topPoint = topPoint;
        }

        public void GetInfo()
        {
            Console.WriteLine
                (
                    $"X: {this.X}, Y:{this.Y}, name:{this.Name}, description:{this.Description}, " +
                    $"top-point: {this._topPoint}"
                );
        }
    }
}
