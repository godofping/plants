namespace plants.PL.Registrations
{
    partial class frmAddImage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSelectImage = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 71);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Image Description:";
            // 
            // txtImageDescription
            // 
            this.txtImageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageDescription.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageDescription.Location = new System.Drawing.Point(22, 360);
            this.txtImageDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImageDescription.Multiline = true;
            this.txtImageDescription.Name = "txtImageDescription";
            this.txtImageDescription.Size = new System.Drawing.Size(984, 148);
            this.txtImageDescription.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select Image";
            // 
            // pbSelectImage
            // 
            this.pbSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSelectImage.Image = global::plants.PL.Properties.Resources._057_folder_1;
            this.pbSelectImage.Location = new System.Drawing.Point(454, 265);
            this.pbSelectImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSelectImage.Name = "pbSelectImage";
            this.pbSelectImage.Size = new System.Drawing.Size(71, 54);
            this.pbSelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectImage.TabIndex = 27;
            this.pbSelectImage.TabStop = false;
            this.pbSelectImage.Click += new System.EventHandler(this.pbSelectImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.Location = new System.Drawing.Point(21, 78);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(264, 241);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 25;
            this.pbImage.TabStop = false;
            // 
            // pbSave
            // 
            this.pbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSave.Image = global::plants.PL.Properties.Resources._062_diskette;
            this.pbSave.Location = new System.Drawing.Point(820, 517);
            this.pbSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(90, 80);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 22;
            this.pbSave.TabStop = false;
            this.toolTip1.SetToolTip(this.pbSave, "Save");
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancel.Image = global::plants.PL.Properties.Resources._010_cancel;
            this.pbCancel.Location = new System.Drawing.Point(916, 517);
            this.pbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(90, 80);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 21;
            this.pbCancel.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCancel, "Cancel");
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // frmAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.pbSelectImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImageDescription);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmAddImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddImage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageDescription;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSelectImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}