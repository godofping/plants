using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plants.PL.Registrations
{
    public partial class frmPlantsList : Form
    {
        public frmPlantsList()
        {
            InitializeComponent();
        }

        private void PopulateItems()
        {
            PlantControls.plant[] plant = new PlantControls.plant[10];

            for (int i = 0; i < plant.Length; i++)
            {
                plant[i] = new PlantControls.plant();
                plant[i].PlantName = "rex";
                plant[i].PlantScientificName = "rex louis";
       

                flpPlants.Controls.Add(plant[i]);

            }
        }

        private void ShowForm(Boolean bol)
        {
            pnlForm.Visible = bol;
            pnlMain.Visible = !bol;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPlantsList_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ShowForm(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddImage_Click(object sender, EventArgs e)
        {
            Registrations.frmAddImage frm = new Registrations.frmAddImage();
            frm.ShowDialog();
        }
    }
}
