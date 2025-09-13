using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOIDS_SIMULATION_NEA_2024
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // makes it centrual in the beginning
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
           
            MainSimulationForm simulationScreen = new MainSimulationForm(); // creates new instance of the Tutorial Screen form 
            simulationScreen.Show();
            Visible = false; // makes it invisible so that the form we open wont be on top the one we close
            simulationScreen.StartPosition = FormStartPosition.Manual; //sets up the location of the form we are currently in
            simulationScreen.Location = this.Location; // remembers it
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            
            TutorialScreen tutorialScreen = new TutorialScreen(); // creates new instance of the Tutorial Screen form 
            tutorialScreen.Show();
            Visible = false; // makes it invisible so that the form we open wont be on top the one we close
            tutorialScreen.StartPosition = FormStartPosition.Manual; // sets up the location of the form we are currently in
            tutorialScreen.Location = this.Location; // remmebers it 
            
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            StartScreen startscrene = new StartScreen();
            startscrene.StartPosition = FormStartPosition.Manual;
            
        }
    }
}
