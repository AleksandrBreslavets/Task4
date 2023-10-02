using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class GeographicObject
    {
        protected double x;
        protected double y;
        protected string name;
        protected string description;

        public GeographicObject(double x, double y, string name, string description)
        {
            this.x = x;
            this.y = y; 
            this.name = name;
            this.description = description;
        }

        virtual public void GetInfo(){}
    }
}
