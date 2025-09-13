using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BOIDS_SIMULATION_NEA_2024
{
    public class Boid // maybe changing it attributes to private
    {
        public double XCentrePosition;
        public double YCentrePosition;
        public double XVelocity;
        public double YVelocity;
        protected double RadiusOfBoid = 10; // maybe changing this constant 
        protected Color BoidsColour;
        public int ID;

        public Boid(double xcentreposition, double ycentreposition, double xvelocity, double yvelocity, double radiusofboid, Color boidscolour, int id)
        {
            XCentrePosition = xcentreposition;
            YCentrePosition = ycentreposition;
            XVelocity = xvelocity;
            YVelocity = yvelocity;
            RadiusOfBoid = radiusofboid;
            BoidsColour = boidscolour;
            ID = id;
        }

        public void MoveBoid(List<Boid> BoidList,
            double CohesionStrength = 1,
            double AlignmentStrength = 1,
            double SeparationStrength = 1,
            double PredatorsSpeed = 1,
            List<Obstacle> ObstacleList = null)
        {
            double SumClosenessX = 0;// CHANGED !!!!!!
            double SumClosenessY = 0;// CHANGED !!!!!!
            double FlockXVelocity = 0;// CHANGED !!!!!!
            double FlockYVelocity = 0;// CHANGED !!!!!!
            double AlignXvelocity = 0;// CHANGED !!!!!!
            double AlignYvelocity = 0;// CHANGED !!!!!!

            var item = this; // this means this class
            var FoundBoids = BoidList.Where(other => (other.GetDistance(item) < 50));
            if (item.GetType().Name == nameof(Boid)) // CHANGED !!!!!!!!!!!
            {
                // checks for objects in distance < 50
                double MeanX = FoundBoids.Sum(other => other.XCentrePosition) / FoundBoids.Count();
                double MeanY = FoundBoids.Sum(other => other.YCentrePosition) / FoundBoids.Count(); //Cohesion Rule
                double DeltaCenterX = MeanX - item.XCentrePosition;
                double DeltaCenterY = MeanY - item.YCentrePosition;
                FlockXVelocity = (DeltaCenterX * 0.0003) * CohesionStrength; // add multiplier, cant be 0 , min max 0<x<=100
                FlockXVelocity = (DeltaCenterY * 0.0003) * CohesionStrength;
            }

            if (item.GetType().Name == nameof(Boid)) // CHANGED !!!!!!
            {
                double MeanXVelocity = FoundBoids.Sum(other => other.XVelocity) / FoundBoids.Count(); // Alignment rule
                double MeanYVelocity = FoundBoids.Sum(other => other.YVelocity) / FoundBoids.Count();
                double DXvelocity = MeanXVelocity - item.XVelocity;
                double DYVelocity = MeanYVelocity - item.YVelocity;
                AlignXvelocity = (DXvelocity * 0.01) * AlignmentStrength;
                AlignYvelocity = (DYVelocity * 0.01) * AlignmentStrength;
            }

            FoundBoids = BoidList.Where(other => other.GetDistance(item) < 20); //Separation rule
            SumClosenessX = 0;
            SumClosenessY = 0;
            foreach (var found in FoundBoids)
            {
                double Closeness = 20 - item.GetDistance(found);
                SumClosenessX += (item.XCentrePosition - found.XCentrePosition) * Closeness;
                SumClosenessY += (item.YCentrePosition - found.YCentrePosition) * Closeness;
            }
            double SeparationXvelocity = (SumClosenessX * 0.001) * SeparationStrength;
            double SeparationYvelocity = (SumClosenessY * 0.001) * SeparationStrength;


            if (this.GetType().Name != nameof(Predator)) // if item from BoidList isnt named with Predator, keep the colour of them as blue
            {
                BoidsColour = Color.Blue;
            }
            foreach (var predator in BoidList)
            {
                if (predator.GetType().Name == nameof(Predator)) // nameof means the text name of the class
                {
                    double DistanceAway = this.GetDistance(predator);
                    if (DistanceAway < 40)
                    {
                        double Closeness = 40 - DistanceAway;
                        SumClosenessX += (XCentrePosition - predator.XCentrePosition) * Closeness;
                        SumClosenessY += (YCentrePosition - predator.YCentrePosition) * Closeness;
                        if (this.GetType().Name != nameof(Predator))
                        {
                            BoidsColour = Color.Yellow;
                        }
                    }
                }
            }
            double PredatorXVelocity = (SumClosenessX * 0.0005) * PredatorsSpeed;
            double PredatorYVelocity = (SumClosenessY * 0.0005) * PredatorsSpeed;


            SumClosenessX = 0;
            SumClosenessY = 0;
            foreach (var obstacle in ObstacleList)
            {
                double DistanceAway = obstacle.GetDistance(new Point((int)this.XCentrePosition, (int)this.YCentrePosition));  //Math.Sqrt(dx * dx + dy * dy);
                if (DistanceAway < (obstacle.Size + 30))
                {
                    double Closeness = (obstacle.Size + 30) - DistanceAway;
                    SumClosenessX += (XCentrePosition - obstacle.Location.X) * Closeness;
                    SumClosenessY += (YCentrePosition - obstacle.Location.Y) * Closeness;

                }

            }
            double ObstacleXVelocity = SumClosenessX * 0.0001; // was originally 0.00005
            double ObstacleYVelocity = SumClosenessY * 0.0001; // was originally 0.00005

            /// Mathematical rules applied
            item.XVelocity += FlockXVelocity + SeparationXvelocity + AlignXvelocity + PredatorXVelocity + ObstacleXVelocity; // combination of rules
            item.YVelocity += FlockYVelocity + SeparationYvelocity + AlignYvelocity + PredatorYVelocity + ObstacleYVelocity; // combination of rules 


        }

        public void MoveLimit(int PicBoxWidth, int PicBoxHeight, bool Wrapping = false, List<Obstacle> ObstacleList = null)
        {
            XCentrePosition += XVelocity;
            YCentrePosition += YVelocity;
            var speed = GetSpeed();
            if (speed > 6)
            {
                XVelocity = (XVelocity / speed) * 2;
                YVelocity = (YVelocity / speed) * 2;
            }
            else if (speed < 0.8)
            {
                XVelocity = (XVelocity / speed) * 0.8;
                YVelocity = (YVelocity / speed) * 0.8;
            }

            if (double.IsNaN(XVelocity)) // Exceptionn handling, if velocity gets too small, make it 0.
                XVelocity = 0;
            if (double.IsNaN(YVelocity))
                YVelocity = 0;


            /// Code that makes circle bounce of the edges of the screen by changing its velocity 
            if (Wrapping)
            {
                if (XCentrePosition < 20)
                {
                    XVelocity += 0.5;
                }
                if (XCentrePosition > PicBoxWidth - 20) // Is it better to add constants or leave it like that
                {
                    XVelocity -= 0.5;
                }

                if (YCentrePosition < 20)
                {
                    YVelocity += 0.5;
                }
                if (YCentrePosition > PicBoxHeight - 20)
                {
                    YVelocity -= 0.5;
                }
            }
            else
            {
                /// Code that makes circles/bodis Wrap Around

                if (XCentrePosition < 0)
                {
                    XCentrePosition = PicBoxWidth;
                }

                if (XCentrePosition > PicBoxWidth)
                {
                    XCentrePosition = 0;
                }

                if (YCentrePosition < 0)
                {
                    YCentrePosition = PicBoxHeight;
                }

                if (YCentrePosition > PicBoxHeight)
                {
                    YCentrePosition = 0;
                }
            }
        }

        public void DrawBoid(Graphics g)
        {
            Pen pen = new Pen(BoidsColour); // Sets up pen with the BoidsColour
            SolidBrush solidbrush = new SolidBrush(BoidsColour); // Sets up brush with the BoidsColour
            g.DrawEllipse(pen, (int)XCentrePosition, (int)YCentrePosition, (int)RadiusOfBoid, (int)RadiusOfBoid);// Draws Elipse with these variables
            g.FillEllipse(solidbrush, (int)XCentrePosition, (int)YCentrePosition, (int)RadiusOfBoid, (int)RadiusOfBoid); // Fills the Elipse with these vertices
        }
        public double GetDistance(Boid OtherBoid) // Checking distance
        {
            double dx = OtherBoid.XCentrePosition - XCentrePosition;
            double dy = OtherBoid.YCentrePosition - YCentrePosition;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double GetSpeed() // speed
        {
            return Math.Sqrt(XVelocity * XVelocity + YVelocity * YVelocity);
        }
    }
}