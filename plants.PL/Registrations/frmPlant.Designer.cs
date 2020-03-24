namespace plants.PL.Registrations
{
    partial class frmPlant
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.pbPlantCategoryPicture = new System.Windows.Forms.PictureBox();
            this.lblPlantCategory = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbMagnifying = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNumberOfResults = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlantCategoryPicture)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnifying)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblNumberOfResults);
            this.pnlMain.Controls.Add(this.dgv);
            this.pnlMain.Controls.Add(this.pnlSplitter);
            this.pnlMain.Controls.Add(this.pbPlantCategoryPicture);
            this.pnlMain.Controls.Add(this.lblPlantCategory);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 1061);
            this.pnlMain.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 205);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(998, 843);
            this.dgv.TabIndex = 12;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(183)))), ((int)(((byte)(203)))));
            this.pnlSplitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(183)))), ((int)(((byte)(203)))));
            this.pnlSplitter.Location = new System.Drawing.Point(12, 187);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(998, 3);
            this.pnlSplitter.TabIndex = 11;
            // 
            // pbPlantCategoryPicture
            // 
            this.pbPlantCategoryPicture.Image = global::plants.PL.Properties.Resources._041_fruit;
            this.pbPlantCategoryPicture.Location = new System.Drawing.Point(12, 74);
            this.pbPlantCategoryPicture.Name = "pbPlantCategoryPicture";
            this.pbPlantCategoryPicture.Size = new System.Drawing.Size(133, 110);
            this.pbPlantCategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlantCategoryPicture.TabIndex = 10;
            this.pbPlantCategoryPicture.TabStop = false;
            // 
            // lblPlantCategory
            // 
            this.lblPlantCategory.AutoSize = true;
            this.lblPlantCategory.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.lblPlantCategory.Location = new System.Drawing.Point(151, 103);
            this.lblPlantCategory.Name = "lblPlantCategory";
            this.lblPlantCategory.Size = new System.Drawing.Size(206, 58);
            this.lblPlantCategory.TabIndex = 8;
            this.lblPlantCategory.Text = "Grasses";
            this.lblPlantCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.pnlSearch.Controls.Add(this.pbAdd);
            this.pnlSearch.Controls.Add(this.pbMagnifying);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1022, 69);
            this.pnlSearch.TabIndex = 7;
            // 
            // pbAdd
            // 
            this.pbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::plants.PL.Properties.Resources._090_add;
            this.pbAdd.Location = new System.Drawing.Point(956, 8);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(55, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 9;
            this.pbAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAdd, "Add Plant");
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbMagnifying
            // 
            this.pbMagnifying.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbMagnifying.Image = global::plants.PL.Properties.Resources._096_search;
            this.pbMagnifying.Location = new System.Drawing.Point(857, 20);
            this.pbMagnifying.Name = "pbMagnifying";
            this.pbMagnifying.Size = new System.Drawing.Size(30, 35);
            this.pbMagnifying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMagnifying.TabIndex = 7;
            this.pbMagnifying.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(123, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(728, 41);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblNumberOfResults
            // 
            this.lblNumberOfResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfResults.Location = new System.Drawing.Point(683, 157);
            this.lblNumberOfResults.Name = "lblNumberOfResults";
            this.lblNumberOfResults.Size = new System.Drawing.Size(321, 24);
            this.lblNumberOfResults.TabIndex = 13;
            this.lblNumberOfResults.Text = "label1";
            this.lblNumberOfResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 1061);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPlant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLANTS DATABASE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlantsList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlantCategoryPicture)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnifying)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPlantCategory;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pbMagnifying;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbPlantCategoryPicture;
        private System.Windows.Forms.Panel pnlSplitter;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblNumberOfResults;
    }
}