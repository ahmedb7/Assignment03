using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Abstract_Planets
{
    class GiantPlanet : Planet
    {
        private int _type;
    
        public void giantPlant(string name, double diameter, double mass, string type)
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}
