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
    public partial class frmPlant : Form
    {
        EL.Registrations.Plantcategories plantcategoryEL = new EL.Registrations.Plantcategories();
        BL.Registrations.Plantcategories plantcategoryBL = new BL.Registrations.Plantcategories();
        public frmPlant(int _plantcategoryid)
        {
            InitializeComponent();
            plantcategoryEL.Plantcategoryid = _plantcategoryid;

            plantcategoryEL = plantcategoryBL.Select(plantcategoryEL);

            lblPlantCategory.Text = plantcategoryEL.Plantcategory;

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void ClearForm()
        {
            txtCommonName.ResetText();
            txtScientificName.ResetText();
            txtFamily.ResetText();
            txtPlantMorphology.ResetText();
            txtEconomicImportance.ResetText();
            pbWholePlant.Image = null;
            pbFlower.Image = null;
            pbLeaves.Image = null;
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


        private void pbAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
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
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbWholePlant.Image = new Bitmap(open.FileName);
            }
        }

        private void pbAddImageFlower_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbFlower.Image = new Bitmap(open.FileName);
            }
        }

        private void pbAddLeavesImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbLeaves.Image = new Bitmap(open.FileName);
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (methods.CheckRequiredTXT(txtCommonName, txtScientificName))
            {
                var plantEL = new EL.Registrations.Plants();
                var plantBL = new BL.Registrations.Plants();

                plantEL.Plantcategoryid = plantcategoryEL.Plantcategoryid;
                plantEL.Plantcommonname = txtCommonName.Text;
                plantEL.Plantscientificname = txtScientificName.Text;
                plantEL.Plantfamily = txtFamily.Text;
                plantEL.Plantmorphology = txtPlantMorphology.Text;
                plantEL.Planteconomicimportance = txtEconomicImportance.Text;
                plantEL.Plantwholeimage = methods.ConvertImageToByteArray(pbWholePlant.Image);
                plantEL.Plantflowerimage = methods.ConvertImageToByteArray(pbFlower.Image);
                plantEL.Plantleavesimage = methods.ConvertImageToByteArray(pbLeaves.Image);

                if (plantBL.Insert(plantEL) > 0)
                {
                    MessageBox.Show("Succesfully saved!");
                    ShowForm(false);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }

            }
            else
            {
                MessageBox.Show("Please fill out all fields marked by *");
            }
        }
    }
}
