namespace plants.PL.PlantControls
{
    partial class plant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlantName = new System.Windows.Forms.Label();
            this.lblScientificName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlantName
            // 
            this.lblPlantName.AutoEllipsis = true;
            this.lblPlantName.AutoSize = true;
            this.lblPlantName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantName.Location = new System.Drawing.Point(192, 48);
            this.lblPlantName.Name = "lblPlantName";
            this.lblPlantName.Size = new System.Drawing.Size(190, 38);
            this.lblPlantName.TabIndex = 1;
            this.lblPlantName.Text = "Allamanda";
            // 
            // lblScientificName
            // 
            this.lblScientificName.AutoEllipsis = true;
            this.lblScientificName.AutoSize = true;
            this.lblScientificName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScientificName.Location = new System.Drawing.Point(195, 86);
            this.lblScientificName.Name = "lblScientificName";
            this.lblScientificName.Size = new System.Drawing.Size(239, 24);
            this.lblScientificName.TabIndex = 2;
            this.lblScientificName.Text = "Allamanda cathartica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 165);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(13, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 5);
            this.panel2.TabIndex = 4;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.Location = new System.Drawing.Point(27, 11);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(153, 136);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // plant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblScientificName);
            this.Controls.Add(this.lblPlantName);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0, 10, 50, 25);
            this.Name = "plant";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(683, 165);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblPlantName;
        private System.Windows.Forms.Label lblScientificName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
