using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIDS_SIMULATION_NEA_2024
{
    public class Predator : Boid
    {
        public Predator(double xcentreposition, double ycentreposition, double xvelocity, double yvelocity, double radiusofboid, Color boidscolour, int id)
        : base(xcentreposition, ycentreposition, xvelocity, yvelocity, radiusofboid, boidscolour, id) // Boids stuff
        {
            
        }
    }
}
