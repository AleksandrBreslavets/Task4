using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class River : GeographicObject
    {
        private double _waterSpeed;
        private double _totalLength;

        public River(double x, double y, string name, string description, double waterSpeed, double totalLength)
            : base(x, y, name, description)
        {
            _waterSpeed = waterSpeed;
            _totalLength = totalLength;
        }

        public override void GetInfo()
        {
            Console.WriteLine
                (
                    $"X: {this.x}, Y:{this.y}, name:{this.name}, description:{this.description}, " +
                    $"water-speed:{this._waterSpeed}, total-length: {this._totalLength}"
                );
        }
    }
}
