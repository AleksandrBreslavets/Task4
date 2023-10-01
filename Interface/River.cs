using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class River : IGeographicObject
    {
        private double _waterSpeed;
        private double _totalLength;

        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public River(double x, double y, string name, string description, double waterSpeed, double totalLength) 
        { 
            X= x;
            Y= y;
            Name = name;
            Description = description;
            _waterSpeed = waterSpeed;
            _totalLength = totalLength;
        }

        public void GetInfo()
        {
            Console.WriteLine
               (
                   $"X: {this.X}, Y:{this.Y}, name:{this.Name}, description:{this.Description}, " +
                   $"water-speed:{this._waterSpeed}, total-length: {this._totalLength}"
               );
        }
    }
}
