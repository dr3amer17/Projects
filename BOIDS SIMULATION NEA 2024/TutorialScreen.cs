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
    public partial class TutorialScreen : Form
    {
        public TutorialScreen()
        {
            InitializeComponent();
        }

        private void TutorialScreen_Load(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TutorialExitButton_Click(object sender, EventArgs e)
        {
            
            StartScreen startScreen = new StartScreen(); // creates new instance of the Tutorial Screen form 
            startScreen.Show();
            Visible = false; // makes it invisible so that the form we open wont be on top the one we close
            startScreen.StartPosition = FormStartPosition.Manual;  // sets up the location of the form we are currently in
            startScreen.Location = this.Location; // remmebers it 


        }


    }
}
