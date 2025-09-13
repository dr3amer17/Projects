namespace BOIDS_SIMULATION_NEA_2024
{
    partial class TutorialScreen
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
            System.Windows.Forms.PictureBox SeparationImage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialScreen));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TutorialExitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlignmentImage = new System.Windows.Forms.PictureBox();
            this.CohesionImage = new System.Windows.Forms.PictureBox();
            this.BirdsFlockingImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            SeparationImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(SeparationImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlignmentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CohesionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdsFlockingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SeparationImage
            // 
            SeparationImage.Image = global::BOIDS_SIMULATION_NEA_2024.Properties.Resources.Separation_Rule;
            SeparationImage.Location = new System.Drawing.Point(38, 511);
            SeparationImage.Name = "SeparationImage";
            SeparationImage.Size = new System.Drawing.Size(196, 130);
            SeparationImage.TabIndex = 7;
            SeparationImage.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutorial";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(38, 165);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(766, 152);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            this.DescriptionLabel.UseCompatibleTextRendering = true;
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // TutorialExitButton
            // 
            this.TutorialExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialExitButton.Location = new System.Drawing.Point(12, 18);
            this.TutorialExitButton.Name = "TutorialExitButton";
            this.TutorialExitButton.Size = new System.Drawing.Size(53, 40);
            this.TutorialExitButton.TabIndex = 3;
            this.TutorialExitButton.Text = "<";
            this.TutorialExitButton.UseVisualStyleBackColor = true;
            this.TutorialExitButton.Click += new System.EventHandler(this.TutorialExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rules explanations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Separation Rule";
            // 
            // AlignmentImage
            // 
            this.AlignmentImage.Image = global::BOIDS_SIMULATION_NEA_2024.Properties.Resources.Alignment_rule;
            this.AlignmentImage.Location = new System.Drawing.Point(795, 511);
            this.AlignmentImage.Name = "AlignmentImage";
            this.AlignmentImage.Size = new System.Drawing.Size(214, 142);
            this.AlignmentImage.TabIndex = 9;
            this.AlignmentImage.TabStop = false;
            // 
            // CohesionImage
            // 
            this.CohesionImage.Image = global::BOIDS_SIMULATION_NEA_2024.Properties.Resources.Cohesion_Rule;
            this.CohesionImage.Location = new System.Drawing.Point(427, 511);
            this.CohesionImage.Name = "CohesionImage";
            this.CohesionImage.Size = new System.Drawing.Size(199, 134);
            this.CohesionImage.TabIndex = 8;
            this.CohesionImage.TabStop = false;
            // 
            // BirdsFlockingImage
            // 
            this.BirdsFlockingImage.Image = global::BOIDS_SIMULATION_NEA_2024.Properties.Resources.Flocking_Picture;
            this.BirdsFlockingImage.Location = new System.Drawing.Point(831, 121);
            this.BirdsFlockingImage.Name = "BirdsFlockingImage";
            this.BirdsFlockingImage.Size = new System.Drawing.Size(429, 232);
            this.BirdsFlockingImage.TabIndex = 4;
            this.BirdsFlockingImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 125);
            this.label4.TabIndex = 10;
            this.label4.Text = "Each boid avoids packed areas. \r\nWith parameter Separation \r\nStrength you will be" +
    " able to chage \r\nhow close boids are in terms of \r\none another.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 150);
            this.label5.TabIndex = 11;
            this.label5.Text = "Each boid avoids leaving it\'s\r\nflock/group. With parameter \r\nCohesion Strength yo" +
    "u can \r\nadjust how strong forces are to \r\npull each boid inside the groups\r\ncent" +
    "re of mass.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cohesion Rule";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alignment Rule";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(777, 676);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 175);
            this.label9.TabIndex = 15;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // TutorialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlignmentImage);
            this.Controls.Add(this.CohesionImage);
            this.Controls.Add(SeparationImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirdsFlockingImage);
            this.Controls.Add(this.TutorialExitButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "TutorialScreen";
            this.Text = "Explanation Screen";
            this.Load += new System.EventHandler(this.TutorialScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(SeparationImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlignmentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CohesionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdsFlockingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button TutorialExitButton;
        private System.Windows.Forms.PictureBox BirdsFlockingImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CohesionImage;
        private System.Windows.Forms.PictureBox AlignmentImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}