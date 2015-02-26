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
                throw new System.NotImplementedException();
            }
            
        }

        public double Mass
        {
            get
            {
                throw new System.NotImplementedException();
            }
           
        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            
        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double RotationPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Planet(string Name, double Diameter, string mass)
        {
            
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
