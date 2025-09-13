using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BOIDS_SIMULATION_NEA_2024
{
    public partial class MainSimulationForm : Form
    {        
        List<Boid> BoidList = new List<Boid>(); // creates a list of Boids objects called ListOfBoids
        Random random = new Random();
        List<Obstacle> ObstacleList = new List<Obstacle>();
        bool Wrapping = false;
        
        public const int BOID_RADIUS = 10; 
        const int BOID_BORDER_RADIUS = 20;
        const int MINIMUM_BOIDS_AMOUNT = 20;
        const int MAXIMUM_BOIDS_AMOUNT = 200;
        const int BOIDS_COUNT = 100;
        
        const int PREDATORS_RADIUS = 20;
        const int PREDATORS_COUNT = 5;

        const int COHESION_VALUE = 1;
        const int COHESION_MIMNIMUM = 1;
        const int COHESION_MAXIMUM = 100;

        const int ALIGNMENT_VALUE = 1;
        const int ALIGNMENT_MIMNIMUM = 1;
        const int ALIGNMENT_MAXIMUM = 100;

        const int SEPARATION_VALUE = 1;
        const int SEPARATION_MIMNIMUM = 1;
        const int SEPARATION_MAXIMUM = 100;

        const int PREDATOR_VALUE = 1;
        const int PREDATOR_MIMNIMUM = 1;
        const int PREDATOR_MAXIMUM = 100;

        const int OBSTACLE_SIZE_VALUE = 50;
        const int OBSTACLE_SIZE_MINIMUM = 10;
        const int OBSTACLE_SIZE_MAXIMUM = 500;


        public MainSimulationForm()
        {
            InitializeComponent();

            NumberOfBoidstrackbar.Minimum = MINIMUM_BOIDS_AMOUNT;
            NumberOfBoidstrackbar.Maximum = MAXIMUM_BOIDS_AMOUNT;
            NumberOfBoidstrackbar.Value = BOIDS_COUNT;
            NumberOfBoidlabel.Text = BOIDS_COUNT.ToString();

            NumberOfPredatorstrackbar.Value = PREDATORS_COUNT;
            NumberOfPredatorslabel.Text = PREDATORS_COUNT.ToString();

            CohesionStrengthtrackBar.Value = COHESION_VALUE;
            CohesionStrengthtrackBar.Minimum = COHESION_MIMNIMUM;
            CohesionStrengthtrackBar.Maximum = COHESION_MAXIMUM;
            CohesionStrengthnumberlabel.Text = CohesionStrengthtrackBar.Value.ToString();

            AlignmentStrengthtrackBar.Value = ALIGNMENT_VALUE;
            AlignmentStrengthtrackBar.Minimum = ALIGNMENT_MIMNIMUM;
            AlignmentStrengthtrackBar.Maximum = ALIGNMENT_MAXIMUM;
            AlignmentStrengthNumberlabel.Text = AlignmentStrengthtrackBar.Value.ToString();

            SeparationStrengthtrackBar.Value = SEPARATION_VALUE;
            SeparationStrengthtrackBar.Minimum = SEPARATION_MIMNIMUM;
            SeparationStrengthtrackBar.Maximum = SEPARATION_MAXIMUM;
            SeparationStrengthNumberlabel.Text = SeparationStrengthtrackBar.Value.ToString();

            PredatorsSpeedtrackBar.Value = PREDATOR_VALUE;
            PredatorsSpeedtrackBar.Minimum = PREDATOR_MIMNIMUM;
            PredatorsSpeedtrackBar.Maximum = PREDATOR_MAXIMUM;
            PredatorsSpeedNumberlabel.Text = PredatorsSpeedtrackBar.Value.ToString();

            ObstacleSizetrackBar.Value = OBSTACLE_SIZE_VALUE;
            ObstacleSizetrackBar.Minimum = OBSTACLE_SIZE_MINIMUM;
            ObstacleSizetrackBar.Maximum = OBSTACLE_SIZE_MAXIMUM;
            ObstacleSizelabel.Text = ObstacleSizetrackBar.Value.ToString();


        }

        private void SimulationBoxPaint(object sender, PaintEventArgs e)
        {
            foreach (Boid Eachboid in BoidList)
            {
                Eachboid.DrawBoid(e.Graphics);
            }
            foreach (Obstacle obstacle in ObstacleList)
            {
                obstacle.Draw(e.Graphics);
            }            
        }
        private void MainSimulationExitButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen(); // creates new instance of the Tutorial Screen form 
            startScreen.Show();
            Visible = false; // makes it invisible so that the form we open wont be on top the one we close
            startScreen.StartPosition = FormStartPosition.Manual;  // sets up the location of the form we are currently in
            startScreen.Location = this.Location; // remmebers it 
        } // button

        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            foreach (Boid EachBoid in BoidList) // check new direction and movement
            {
                EachBoid.MoveBoid(BoidList, CohesionStrengthtrackBar.Value,AlignmentStrengthtrackBar.Value,
                    SeparationStrengthtrackBar.Value, PredatorsSpeedtrackBar.Value, ObstacleList);
            }
            
            foreach (Boid EachBoid in BoidList) // check if they have to change direction or limit it
            {
                EachBoid.MoveLimit(SimulationScreenPicBox.Width, SimulationScreenPicBox.Height, Wrapping, ObstacleList);
            }
            SimulationScreenPicBox.Invalidate(); // redraws
        }

        private void MainSimulationForm_Load(object sender, EventArgs e)
        {
            

            int Index = 0;
            int PredatorAmount = NumberOfPredatorstrackbar.Value;
            int BoidsAmount = NumberOfBoidstrackbar.Value;
            while (Index < PredatorAmount) // create predators
            {
                AddPredators(Index);
                Index++;
            }
            
            while (true) // iterating until boids = boidsamount
            {
                bool IsColliding = false;
                Boid NewBoid = newBoid(Index);
                Index++;

                if (BoidList.Count == 0)
                {
                    BoidList.Add(NewBoid);
                    if (BoidList.Count >= BoidsAmount) break;
                    continue;
                }

                for (int i = 0; i < BoidList.Count; i++)
                {
                    
                    if (BoidList.Count < 2)
                    {
                        double XDifference = BoidList[0].XCentrePosition - NewBoid.XCentrePosition;
                        double YDifference = BoidList[0].YCentrePosition - NewBoid.YCentrePosition;
                        double BoidsDistance = Math.Sqrt(Math.Pow(XDifference, 2) + Math.Pow(YDifference, 2));
                        if (BOID_BORDER_RADIUS < BoidsDistance)
                        {
                            BoidList.Add(NewBoid);
                        }
                        if (BoidList.Count >= BoidsAmount) break;
                    }
                    
                    else if (!IsColliding)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            double XDifference = BoidList[j].XCentrePosition - NewBoid.XCentrePosition;
                            double YDifference = BoidList[j].YCentrePosition - NewBoid.YCentrePosition;
                            double BoidsDistance = Math.Sqrt(Math.Pow(XDifference, 2) + Math.Pow(YDifference, 2));
                            
                            if (BOID_BORDER_RADIUS > BoidsDistance && !IsColliding)
                            {
                                IsColliding = true;
                                break;
                            }
                            if (BoidList.Count >= BoidsAmount) break;
                        }
                    }

                }

                if (!IsColliding) { BoidList.Add(NewBoid); }
                if (BoidList.Count >= BoidsAmount) break;
            }
        }

        private void StartStopSimulationButton_Click(object sender, EventArgs e) // start and stop button
        {
            if (SimulationTimer.Enabled == true)
            {
                SimulationTimer.Enabled = false;
                StartStopSimulationButton.Text = "Start";
            }
            else
            {
                SimulationTimer.Enabled = true;
                StartStopSimulationButton.Text = "Stop";
            }
        } 

        private void NumberOfBoidstrackbar_Scroll(object sender, EventArgs e)
        {
            NumberOfBoidlabel.Text = NumberOfBoidstrackbar.Value.ToString();
            int BoidsAmount = NumberOfBoidstrackbar.Value;
            int Index = 0;

            for (int i = BoidList.Count() - 1; i >= 0; i--)
            {
                if ((BoidList[i].GetType().Name == nameof(Boid)))
                {
                    if (BoidsAmount > 0)
                    {
                        BoidsAmount--;
                    }
                    else
                    {
                        BoidList.RemoveAt(i);
                    }
                    continue;
                }
                if (BoidList[i].ID > Index)
                {
                    Index = BoidList[i].ID;
                }
            }
            for (int i = 0; i < BoidsAmount; i++)
            {
                Index++;
                BoidList.Add(newBoid(Index));
            }

        }

        private void WrapAroundbutton_Click(object sender, EventArgs e) // Wrap Around button
        {
            if (Wrapping == true) // checks if its true
            {
                WrapAroundbutton.Text = "Wrapping"; // if yes then changes text in the the button
                Wrapping = false; 
            }
            else
            {
                WrapAroundbutton.Text = "Not Wrapping"; // if no changes text in the button
                Wrapping = true;
            }
        }

        private void NumberOfPredatorstrackbar_Scroll(object sender, EventArgs e)
        {
            NumberOfPredatorslabel.Text = NumberOfPredatorstrackbar.Value.ToString();
            int PredatorAmount = NumberOfPredatorstrackbar.Value;
            int Index = 0;

            for (int i = BoidList.Count()-1; i >= 0; i--)
            {
                if ((BoidList[i].GetType().Name == nameof(Predator)))
                {
                    if (PredatorAmount > 0)
                    {
                        PredatorAmount--;
                    }
                    else
                    {
                        BoidList.RemoveAt(i);
                    }
                    continue;
                }
                if (BoidList[i].ID > Index)
                {
                    Index = BoidList[i].ID;
                }
            }
            for (int i = 0; i < PredatorAmount; i++) 
            {
                Index++;
                AddPredators(Index);
            }
        }

        private void AddPredators(int ID)
        {
            Predator NewPredator = new Predator(
                   random.Next(40, SimulationScreenPicBox.Width - 40),
                   random.Next(40, SimulationScreenPicBox.Height - 40),
                   random.Next(-30, 30) / 10,
                   random.Next(-30, 30) / 10, PREDATORS_RADIUS, // use constants instead of numebrs
                   Color.Red, ID);
            BoidList.Add(NewPredator);
        }
        private Boid newBoid(int ID)
        {
            Boid NewBoid = new Boid(
                    random.Next(20, SimulationScreenPicBox.Width - 20),
                    random.Next(20, SimulationScreenPicBox.Height - 20),
                    random.Next(-30, 30) / 10,
                    random.Next(-30, 30) / 10, BOID_RADIUS, // use constants instead of numebrs
                    Color.Blue, ID);
            return NewBoid;
        }        

        private void SimulationScreenPicBox_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs MouseLocation = e as MouseEventArgs;
            for ( int i = ObstacleList.Count - 1; i >= 0; i--)
            {

                if( ObstacleList[i].GetDistance(new Point(MouseLocation.X, MouseLocation.Y)) < ObstacleList[i].Size)
                {
                    ObstacleList.RemoveAt(i);
                    SimulationScreenPicBox.Invalidate();
                    return;
                }
            }
         
            ObstacleList.Add(new Obstacle(MouseLocation.Location, ObstacleSizetrackBar.Value));
            SimulationScreenPicBox.Invalidate();
            
        }

        private void CohesionStrengthtrackBar_Scroll(object sender, EventArgs e)
        {
            CohesionStrengthnumberlabel.Text = CohesionStrengthtrackBar.Value.ToString();            
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            BoidList.Clear();
            ObstacleList.Clear();
            MainSimulationForm_Load(null, null);
            
        }

        private void ObstacleSizetrackBar_Scroll(object sender, EventArgs e)
        {
            ObstacleSizelabel.Text = ObstacleSizetrackBar.Value.ToString();
            foreach (var item in ObstacleList)
            {
                item.Size = ObstacleSizetrackBar.Value;
            }
        }

        private void AlignmentStrengthtrackBar_Scroll(object sender, EventArgs e)
        {
            AlignmentStrengthNumberlabel.Text = AlignmentStrengthtrackBar.Value.ToString();
        }

        private void SeparationStrengthtrackBar_Scroll(object sender, EventArgs e)
        {
            SeparationStrengthNumberlabel.Text = SeparationStrengthtrackBar.Value.ToString();
        }

        private void PredatorsSpeedtrackBar_Scroll(object sender, EventArgs e)
        {
            PredatorsSpeedNumberlabel.Text = PredatorsSpeedtrackBar.Value.ToString();
        }
    }
}
 