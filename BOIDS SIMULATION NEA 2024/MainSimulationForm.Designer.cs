namespace BOIDS_SIMULATION_NEA_2024
{
    partial class MainSimulationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SimulationTimer = new System.Windows.Forms.Timer(this.components);
            this.SimulationScreenPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainSimulationExitButton = new System.Windows.Forms.Button();
            this.StartStopSimulationButton = new System.Windows.Forms.Button();
            this.NumberOfBoidstrackbar = new System.Windows.Forms.TrackBar();
            this.NumberOfPredatorstrackbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfBoidlabel = new System.Windows.Forms.Label();
            this.NumberOfPredatorslabel = new System.Windows.Forms.Label();
            this.WrapAroundbutton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.Cohesionlabel = new System.Windows.Forms.Label();
            this.Alignmentlabel = new System.Windows.Forms.Label();
            this.Separationlabel = new System.Windows.Forms.Label();
            this.AlignmentStrengthtrackBar = new System.Windows.Forms.TrackBar();
            this.CohesionStrengthnumberlabel = new System.Windows.Forms.Label();
            this.AlignmentStrengthNumberlabel = new System.Windows.Forms.Label();
            this.SeparationStrengthNumberlabel = new System.Windows.Forms.Label();
            this.SeparationStrengthtrackBar = new System.Windows.Forms.TrackBar();
            this.CohesionStrengthtrackBar = new System.Windows.Forms.TrackBar();
            this.Predatorlabel = new System.Windows.Forms.Label();
            this.PredatorsSpeedNumberlabel = new System.Windows.Forms.Label();
            this.PredatorsSpeedtrackBar = new System.Windows.Forms.TrackBar();
            this.ObstacleSizetrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.ObstacleSizelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationScreenPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBoidstrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPredatorstrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlignmentStrengthtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparationStrengthtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CohesionStrengthtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorsSpeedtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleSizetrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationTimer
            // 
            this.SimulationTimer.Interval = 10;
            this.SimulationTimer.Tick += new System.EventHandler(this.SimulationTimer_Tick);
            // 
            // SimulationScreenPicBox
            // 
            this.SimulationScreenPicBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SimulationScreenPicBox.Location = new System.Drawing.Point(0, 0);
            this.SimulationScreenPicBox.Name = "SimulationScreenPicBox";
            this.SimulationScreenPicBox.Size = new System.Drawing.Size(1150, 1000);
            this.SimulationScreenPicBox.TabIndex = 0;
            this.SimulationScreenPicBox.TabStop = false;
            this.SimulationScreenPicBox.Click += new System.EventHandler(this.SimulationScreenPicBox_Click);
            this.SimulationScreenPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SimulationBoxPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1228, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // MainSimulationExitButton
            // 
            this.MainSimulationExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSimulationExitButton.Location = new System.Drawing.Point(1401, 12);
            this.MainSimulationExitButton.Name = "MainSimulationExitButton";
            this.MainSimulationExitButton.Size = new System.Drawing.Size(71, 38);
            this.MainSimulationExitButton.TabIndex = 3;
            this.MainSimulationExitButton.Text = "Exit";
            this.MainSimulationExitButton.UseVisualStyleBackColor = true;
            this.MainSimulationExitButton.Click += new System.EventHandler(this.MainSimulationExitButton_Click);
            // 
            // StartStopSimulationButton
            // 
            this.StartStopSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopSimulationButton.Location = new System.Drawing.Point(1168, 88);
            this.StartStopSimulationButton.Name = "StartStopSimulationButton";
            this.StartStopSimulationButton.Size = new System.Drawing.Size(86, 44);
            this.StartStopSimulationButton.TabIndex = 4;
            this.StartStopSimulationButton.Text = "Start";
            this.StartStopSimulationButton.UseVisualStyleBackColor = true;
            this.StartStopSimulationButton.Click += new System.EventHandler(this.StartStopSimulationButton_Click);
            // 
            // NumberOfBoidstrackbar
            // 
            this.NumberOfBoidstrackbar.Location = new System.Drawing.Point(1168, 256);
            this.NumberOfBoidstrackbar.Maximum = 200;
            this.NumberOfBoidstrackbar.Minimum = 20;
            this.NumberOfBoidstrackbar.Name = "NumberOfBoidstrackbar";
            this.NumberOfBoidstrackbar.Size = new System.Drawing.Size(117, 45);
            this.NumberOfBoidstrackbar.TabIndex = 6;
            this.NumberOfBoidstrackbar.Value = 20;
            this.NumberOfBoidstrackbar.Scroll += new System.EventHandler(this.NumberOfBoidstrackbar_Scroll);
            // 
            // NumberOfPredatorstrackbar
            // 
            this.NumberOfPredatorstrackbar.Location = new System.Drawing.Point(1327, 256);
            this.NumberOfPredatorstrackbar.Maximum = 5;
            this.NumberOfPredatorstrackbar.Name = "NumberOfPredatorstrackbar";
            this.NumberOfPredatorstrackbar.Size = new System.Drawing.Size(132, 45);
            this.NumberOfPredatorstrackbar.TabIndex = 7;
            this.NumberOfPredatorstrackbar.Scroll += new System.EventHandler(this.NumberOfPredatorstrackbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1165, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Boids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1323, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Predators";
            // 
            // NumberOfBoidlabel
            // 
            this.NumberOfBoidlabel.AutoSize = true;
            this.NumberOfBoidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfBoidlabel.Location = new System.Drawing.Point(1175, 288);
            this.NumberOfBoidlabel.Name = "NumberOfBoidlabel";
            this.NumberOfBoidlabel.Size = new System.Drawing.Size(14, 16);
            this.NumberOfBoidlabel.TabIndex = 10;
            this.NumberOfBoidlabel.Text = "0";
            // 
            // NumberOfPredatorslabel
            // 
            this.NumberOfPredatorslabel.AutoSize = true;
            this.NumberOfPredatorslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPredatorslabel.Location = new System.Drawing.Point(1333, 288);
            this.NumberOfPredatorslabel.Name = "NumberOfPredatorslabel";
            this.NumberOfPredatorslabel.Size = new System.Drawing.Size(14, 16);
            this.NumberOfPredatorslabel.TabIndex = 11;
            this.NumberOfPredatorslabel.Text = "0";
            // 
            // WrapAroundbutton
            // 
            this.WrapAroundbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrapAroundbutton.Location = new System.Drawing.Point(1309, 88);
            this.WrapAroundbutton.Name = "WrapAroundbutton";
            this.WrapAroundbutton.Size = new System.Drawing.Size(150, 44);
            this.WrapAroundbutton.TabIndex = 14;
            this.WrapAroundbutton.Text = "Wrapping";
            this.WrapAroundbutton.UseVisualStyleBackColor = true;
            this.WrapAroundbutton.Click += new System.EventHandler(this.WrapAroundbutton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(1233, 159);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(143, 39);
            this.RestartButton.TabIndex = 15;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Cohesionlabel
            // 
            this.Cohesionlabel.AutoSize = true;
            this.Cohesionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cohesionlabel.Location = new System.Drawing.Point(1239, 316);
            this.Cohesionlabel.Name = "Cohesionlabel";
            this.Cohesionlabel.Size = new System.Drawing.Size(142, 20);
            this.Cohesionlabel.TabIndex = 16;
            this.Cohesionlabel.Text = "Cohesion Strength";
            // 
            // Alignmentlabel
            // 
            this.Alignmentlabel.AutoSize = true;
            this.Alignmentlabel.Location = new System.Drawing.Point(1239, 439);
            this.Alignmentlabel.Name = "Alignmentlabel";
            this.Alignmentlabel.Size = new System.Drawing.Size(146, 20);
            this.Alignmentlabel.TabIndex = 17;
            this.Alignmentlabel.Text = "Alignment Strength";
            // 
            // Separationlabel
            // 
            this.Separationlabel.AutoSize = true;
            this.Separationlabel.Location = new System.Drawing.Point(1239, 573);
            this.Separationlabel.Name = "Separationlabel";
            this.Separationlabel.Size = new System.Drawing.Size(153, 20);
            this.Separationlabel.TabIndex = 18;
            this.Separationlabel.Text = "Separation Strength";
            // 
            // AlignmentStrengthtrackBar
            // 
            this.AlignmentStrengthtrackBar.Location = new System.Drawing.Point(1178, 494);
            this.AlignmentStrengthtrackBar.Name = "AlignmentStrengthtrackBar";
            this.AlignmentStrengthtrackBar.Size = new System.Drawing.Size(281, 45);
            this.AlignmentStrengthtrackBar.TabIndex = 20;
            this.AlignmentStrengthtrackBar.Scroll += new System.EventHandler(this.AlignmentStrengthtrackBar_Scroll);
            // 
            // CohesionStrengthnumberlabel
            // 
            this.CohesionStrengthnumberlabel.AutoSize = true;
            this.CohesionStrengthnumberlabel.Location = new System.Drawing.Point(1184, 394);
            this.CohesionStrengthnumberlabel.Name = "CohesionStrengthnumberlabel";
            this.CohesionStrengthnumberlabel.Size = new System.Drawing.Size(18, 20);
            this.CohesionStrengthnumberlabel.TabIndex = 22;
            this.CohesionStrengthnumberlabel.Text = "0";
            // 
            // AlignmentStrengthNumberlabel
            // 
            this.AlignmentStrengthNumberlabel.AutoSize = true;
            this.AlignmentStrengthNumberlabel.Location = new System.Drawing.Point(1184, 529);
            this.AlignmentStrengthNumberlabel.Name = "AlignmentStrengthNumberlabel";
            this.AlignmentStrengthNumberlabel.Size = new System.Drawing.Size(18, 20);
            this.AlignmentStrengthNumberlabel.TabIndex = 23;
            this.AlignmentStrengthNumberlabel.Text = "0";
            // 
            // SeparationStrengthNumberlabel
            // 
            this.SeparationStrengthNumberlabel.AutoSize = true;
            this.SeparationStrengthNumberlabel.Location = new System.Drawing.Point(1184, 664);
            this.SeparationStrengthNumberlabel.Name = "SeparationStrengthNumberlabel";
            this.SeparationStrengthNumberlabel.Size = new System.Drawing.Size(18, 20);
            this.SeparationStrengthNumberlabel.TabIndex = 24;
            this.SeparationStrengthNumberlabel.Text = "0";
            // 
            // SeparationStrengthtrackBar
            // 
            this.SeparationStrengthtrackBar.Location = new System.Drawing.Point(1178, 627);
            this.SeparationStrengthtrackBar.Name = "SeparationStrengthtrackBar";
            this.SeparationStrengthtrackBar.Size = new System.Drawing.Size(281, 45);
            this.SeparationStrengthtrackBar.TabIndex = 25;
            this.SeparationStrengthtrackBar.Scroll += new System.EventHandler(this.SeparationStrengthtrackBar_Scroll);
            // 
            // CohesionStrengthtrackBar
            // 
            this.CohesionStrengthtrackBar.Location = new System.Drawing.Point(1178, 360);
            this.CohesionStrengthtrackBar.Maximum = 100;
            this.CohesionStrengthtrackBar.Minimum = 1;
            this.CohesionStrengthtrackBar.Name = "CohesionStrengthtrackBar";
            this.CohesionStrengthtrackBar.Size = new System.Drawing.Size(281, 45);
            this.CohesionStrengthtrackBar.TabIndex = 26;
            this.CohesionStrengthtrackBar.Value = 1;
            this.CohesionStrengthtrackBar.Scroll += new System.EventHandler(this.CohesionStrengthtrackBar_Scroll);
            // 
            // Predatorlabel
            // 
            this.Predatorlabel.AutoSize = true;
            this.Predatorlabel.Location = new System.Drawing.Point(1239, 716);
            this.Predatorlabel.Name = "Predatorlabel";
            this.Predatorlabel.Size = new System.Drawing.Size(132, 20);
            this.Predatorlabel.TabIndex = 27;
            this.Predatorlabel.Text = "Predator\'s Speed";
            // 
            // PredatorsSpeedNumberlabel
            // 
            this.PredatorsSpeedNumberlabel.AutoSize = true;
            this.PredatorsSpeedNumberlabel.Location = new System.Drawing.Point(1184, 792);
            this.PredatorsSpeedNumberlabel.Name = "PredatorsSpeedNumberlabel";
            this.PredatorsSpeedNumberlabel.Size = new System.Drawing.Size(18, 20);
            this.PredatorsSpeedNumberlabel.TabIndex = 28;
            this.PredatorsSpeedNumberlabel.Text = "0";
            // 
            // PredatorsSpeedtrackBar
            // 
            this.PredatorsSpeedtrackBar.Location = new System.Drawing.Point(1178, 755);
            this.PredatorsSpeedtrackBar.Name = "PredatorsSpeedtrackBar";
            this.PredatorsSpeedtrackBar.Size = new System.Drawing.Size(281, 45);
            this.PredatorsSpeedtrackBar.TabIndex = 29;
            this.PredatorsSpeedtrackBar.Scroll += new System.EventHandler(this.PredatorsSpeedtrackBar_Scroll);
            // 
            // ObstacleSizetrackBar
            // 
            this.ObstacleSizetrackBar.Location = new System.Drawing.Point(1169, 899);
            this.ObstacleSizetrackBar.Maximum = 500;
            this.ObstacleSizetrackBar.Minimum = 10;
            this.ObstacleSizetrackBar.Name = "ObstacleSizetrackBar";
            this.ObstacleSizetrackBar.Size = new System.Drawing.Size(281, 45);
            this.ObstacleSizetrackBar.TabIndex = 30;
            this.ObstacleSizetrackBar.Value = 50;
            this.ObstacleSizetrackBar.Scroll += new System.EventHandler(this.ObstacleSizetrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1239, 857);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Obstacles Size";
            // 
            // ObstacleSizelabel
            // 
            this.ObstacleSizelabel.AutoSize = true;
            this.ObstacleSizelabel.Location = new System.Drawing.Point(1184, 935);
            this.ObstacleSizelabel.Name = "ObstacleSizelabel";
            this.ObstacleSizelabel.Size = new System.Drawing.Size(18, 20);
            this.ObstacleSizelabel.TabIndex = 32;
            this.ObstacleSizelabel.Text = "0";
            // 
            // MainSimulationForm
            // 
            this.ClientSize = new System.Drawing.Size(1484, 1001);
            this.Controls.Add(this.ObstacleSizelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ObstacleSizetrackBar);
            this.Controls.Add(this.PredatorsSpeedNumberlabel);
            this.Controls.Add(this.PredatorsSpeedtrackBar);
            this.Controls.Add(this.Predatorlabel);
            this.Controls.Add(this.SeparationStrengthNumberlabel);
            this.Controls.Add(this.CohesionStrengthnumberlabel);
            this.Controls.Add(this.CohesionStrengthtrackBar);
            this.Controls.Add(this.SeparationStrengthtrackBar);
            this.Controls.Add(this.AlignmentStrengthNumberlabel);
            this.Controls.Add(this.AlignmentStrengthtrackBar);
            this.Controls.Add(this.Separationlabel);
            this.Controls.Add(this.Alignmentlabel);
            this.Controls.Add(this.Cohesionlabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.WrapAroundbutton);
            this.Controls.Add(this.NumberOfPredatorslabel);
            this.Controls.Add(this.NumberOfBoidlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfPredatorstrackbar);
            this.Controls.Add(this.NumberOfBoidstrackbar);
            this.Controls.Add(this.StartStopSimulationButton);
            this.Controls.Add(this.MainSimulationExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimulationScreenPicBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1500, 1040);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "MainSimulationForm";
            this.Load += new System.EventHandler(this.MainSimulationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SimulationScreenPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBoidstrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPredatorstrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlignmentStrengthtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparationStrengthtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CohesionStrengthtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorsSpeedtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleSizetrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer SimulationTimer;
        private System.Windows.Forms.PictureBox SimulationScreenPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainSimulationExitButton;
        private System.Windows.Forms.Button StartStopSimulationButton;
        private System.Windows.Forms.TrackBar NumberOfBoidstrackbar;
        private System.Windows.Forms.TrackBar NumberOfPredatorstrackbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfBoidlabel;
        private System.Windows.Forms.Label NumberOfPredatorslabel;
        private System.Windows.Forms.Button WrapAroundbutton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label Cohesionlabel;
        private System.Windows.Forms.Label Alignmentlabel;
        private System.Windows.Forms.Label Separationlabel;
        private System.Windows.Forms.TrackBar AlignmentStrengthtrackBar;
        private System.Windows.Forms.Label CohesionStrengthnumberlabel;
        private System.Windows.Forms.Label AlignmentStrengthNumberlabel;
        private System.Windows.Forms.Label SeparationStrengthNumberlabel;
        private System.Windows.Forms.TrackBar SeparationStrengthtrackBar;
        private System.Windows.Forms.TrackBar CohesionStrengthtrackBar;
        private System.Windows.Forms.Label Predatorlabel;
        private System.Windows.Forms.Label PredatorsSpeedNumberlabel;
        private System.Windows.Forms.TrackBar PredatorsSpeedtrackBar;
        private System.Windows.Forms.TrackBar ObstacleSizetrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ObstacleSizelabel;
    }
}