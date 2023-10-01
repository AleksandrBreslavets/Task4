using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Mountain : GeographicObject
    {
        private double _topPoint;

        public Mountain(double x, double y, string name, string description, double topPoint)
            : base(x, y, name, description)
        {
            _topPoint = topPoint;
        }

        public override void GetInfo()
        {
            Console.WriteLine
                (
                    $"X: {this.x}, Y:{this.y}, name:{this.name}, description:{this.description}, " +
                    $"top-point: {this._topPoint}"
                );
        }
    }
}
