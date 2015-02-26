using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Abstract_Planets
{
    abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
            
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
           
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._diameter;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        public Planet(string Name, double Diameter, string mass)
        {
            this._name = name;
            this._mass = mass;
            this._diameter = diameter;
        }

        public override string ToString()
        {
            return this.Name 
                + " has the diameter of " + this.Diameter 
                + " kilometers and a mass of " + this.Mass + " tonnes.";
        }
    }
}
