namespace plants.PL
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSideBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTrees = new System.Windows.Forms.Button();
            this.btnShrubs = new System.Windows.Forms.Button();
            this.btnHerbs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGrasses = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.pnlMenu.Controls.Add(this.pnlSideBox);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnTrees);
            this.pnlMenu.Controls.Add(this.btnShrubs);
            this.pnlMenu.Controls.Add(this.btnHerbs);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnGrasses);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(147, 561);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSideBox
            // 
            this.pnlSideBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(229)))), ((int)(((byte)(254)))));
            this.pnlSideBox.Location = new System.Drawing.Point(5, 98);
            this.pnlSideBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSideBox.Name = "pnlSideBox";
            this.pnlSideBox.Size = new System.Drawing.Size(9, 99);
            this.pnlSideBox.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTrees
            // 
            this.btnTrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.btnTrees.FlatAppearance.BorderSize = 0;
            this.btnTrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrees.ForeColor = System.Drawing.Color.White;
            this.btnTrees.Image = global::plants.PL.Properties.Resources.trees;
            this.btnTrees.Location = new System.Drawing.Point(4, 407);
            this.btnTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrees.Name = "btnTrees";
            this.btnTrees.Size = new System.Drawing.Size(139, 99);
            this.btnTrees.TabIndex = 9;
            this.btnTrees.Text = "Trees";
            this.btnTrees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrees.UseVisualStyleBackColor = false;
            this.btnTrees.Click += new System.EventHandler(this.btnTrees_Click);
            // 
            // btnShrubs
            // 
            this.btnShrubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.btnShrubs.FlatAppearance.BorderSize = 0;
            this.btnShrubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrubs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShrubs.ForeColor = System.Drawing.Color.White;
            this.btnShrubs.Image = global::plants.PL.Properties.Resources.bushes;
            this.btnShrubs.Location = new System.Drawing.Point(4, 304);
            this.btnShrubs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShrubs.Name = "btnShrubs";
            this.btnShrubs.Size = new System.Drawing.Size(139, 99);
            this.btnShrubs.TabIndex = 8;
            this.btnShrubs.Text = "Shrubs";
            this.btnShrubs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShrubs.UseVisualStyleBackColor = false;
            this.btnShrubs.Click += new System.EventHandler(this.btnShrubs_Click);
            // 
            // btnHerbs
            // 
            this.btnHerbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.btnHerbs.FlatAppearance.BorderSize = 0;
            this.btnHerbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerbs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerbs.ForeColor = System.Drawing.Color.White;
            this.btnHerbs.Image = global::plants.PL.Properties.Resources.onion;
            this.btnHerbs.Location = new System.Drawing.Point(4, 201);
            this.btnHerbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHerbs.Name = "btnHerbs";
            this.btnHerbs.Size = new System.Drawing.Size(139, 99);
            this.btnHerbs.TabIndex = 7;
            this.btnHerbs.Text = "Herbs";
            this.btnHerbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHerbs.UseVisualStyleBackColor = false;
            this.btnHerbs.Click += new System.EventHandler(this.btnHerbs_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.panel2.Location = new System.Drawing.Point(5, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 2);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plants Information System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::plants.PL.Properties.Resources._043_tulips;
            this.pictureBox1.Location = new System.Drawing.Point(54, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGrasses
            // 
            this.btnGrasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(176)))));
            this.btnGrasses.FlatAppearance.BorderSize = 0;
            this.btnGrasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrasses.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasses.ForeColor = System.Drawing.Color.White;
            this.btnGrasses.Image = global::plants.PL.Properties.Resources.grass;
            this.btnGrasses.Location = new System.Drawing.Point(4, 98);
            this.btnGrasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrasses.Name = "btnGrasses";
            this.btnGrasses.Size = new System.Drawing.Size(139, 99);
            this.btnGrasses.TabIndex = 0;
            this.btnGrasses.Text = "Grasses";
            this.btnGrasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrasses.UseVisualStyleBackColor = false;
            this.btnGrasses.Click += new System.EventHandler(this.btnGrasses_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoSize = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(147, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1116, 561);
            this.pnlMain.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plants Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnGrasses;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTrees;
        private System.Windows.Forms.Button btnShrubs;
        private System.Windows.Forms.Button btnHerbs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlSideBox;
    }
}

