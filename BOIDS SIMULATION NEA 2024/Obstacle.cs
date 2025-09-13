using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BOIDS_SIMULATION_NEA_2024
{
    public class Obstacle
    {
        private Point location;
        private int size;

        public Point Location { get { return location; } set { location = value; CalculateSize(); } }
       
        
        public int Size { get { return size; } set { size = value; CalculateSize(); } } // value is always a prameter of set, it correlates with the type of the function we are assigning it to



        public Point[] points = new Point[6];

        public Obstacle(Point location, int size)
        {
            Location = location;
            Size = size;
            CalculateSize();
        }

        // Method to draw the obstacle (hexagon)
        public void Draw(Graphics graphics)
        {
            SolidBrush solidbrush = new SolidBrush(Color.DarkGray); // Sets up brush with the BoidsColour

            //graphics.DrawPolygon(Pens.DarkGray, points);
            graphics.FillPolygon(solidbrush, points);
        }
        private void CalculateSize()
        {
            double angle = Math.PI / 3.0;
            for (int i = 0; i < 6; i++)
            {
                points[i] = new Point
                    (
                    (int)(Location.X + Size * Math.Cos(i * angle)),
                    (int)(Location.Y + Size * Math.Sin(i * angle))
                    );
            }
        }
        public double GetDistance(Point otherlocation) // Checking distance
        {
            double dx = otherlocation.X - location.X;
            double dy = otherlocation.Y - location.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
