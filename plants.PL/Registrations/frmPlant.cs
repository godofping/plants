using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plants.PL.Registrations
{
    public partial class frmPlant : Form
    {

        string s = "";
        Thread delayedCalculationThreadDGV;
        int delay = 0;

        EL.Registrations.Plants plantEL = new EL.Registrations.Plants();
        EL.Registrations.Plantcategories plantcategoryEL = new EL.Registrations.Plantcategories();

        BL.Registrations.Plants plantBL = new BL.Registrations.Plants();
        BL.Registrations.Plantcategories plantcategoryBL = new BL.Registrations.Plantcategories();
        public frmPlant(int _plantcategoryid, Image img)
        {
            InitializeComponent();
            plantcategoryEL.Plantcategoryid = _plantcategoryid;

            plantcategoryEL = plantcategoryBL.Select(plantcategoryEL);

            lblPlantCategory.Text = plantcategoryEL.Plantcategory;
            pbPlantCategoryPicture.Image = img;

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

        public class BufferedPanel : Panel
        {
            public BufferedPanel()
            {
                DoubleBuffered = true;
            }
        }

        private void CalculateAfterStopTypingDGV()
        {
            delay += 200;
            if (delayedCalculationThreadDGV != null && delayedCalculationThreadDGV.IsAlive)
                return;

            delayedCalculationThreadDGV = new Thread(() =>
            {
                while (delay >= 200)
                {
                    delay = delay - 200;
                    try
                    {
                        Thread.Sleep(200);
                    }
                    catch (Exception) { }
                }
                Invoke(new Action(() =>
                {
                    PopulateDGV();
                }));
            });

            delayedCalculationThreadDGV.Start();
        }

        private void ManageDGV()
        {
            PopulateDGV();
            methods.DGVTheme(dgv);
            methods.DGVRenameColumns(dgv, "plantid", "Common Name", "Scientific Name");
            methods.DGVHiddenColumns(dgv, "plantid");
            methods.DGVBUTTONEditDelete(dgv);
        }

        private void PopulateDGV()
        {
            methods.LoadDGV(dgv, plantBL.List(plantcategoryEL.Plantcategoryid, txtSearch.Text));
        }


        private void ResetForm()
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

        private void ShowForm(Boolean bol)
        {
            pnlForm.Visible = bol;
            pnlMain.Visible = !bol;
            ResetForm();
        }


        private void ShowResult(bool bol)
        {
            if (bol)
            {
                MessageBox.Show("Success");
                PopulateDGV();
                ShowForm(false);
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }


        private void frmPlantsList_Load(object sender, EventArgs e)
        {
            ShowForm(false);
            ManageDGV();
        }


        private void pbAdd_Click(object sender, EventArgs e)
        {
            s = "ADD";
            ShowForm(true);
            lblHeader.Text = "Add Plant";
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
            if (methods.CheckRequiredTXT(txtCommonName, txtScientificName) & pbWholePlant.Image != null)
            {

                plantEL.Plantcategoryid = plantcategoryEL.Plantcategoryid;
                plantEL.Plantcommonname = txtCommonName.Text;
                plantEL.Plantscientificname = txtScientificName.Text;
                plantEL.Plantfamily = txtFamily.Text;
                plantEL.Plantmorphology = txtPlantMorphology.Text;
                plantEL.Planteconomicimportance = txtEconomicImportance.Text;
                plantEL.Plantwholeimage = methods.ConvertImageToByteArray(pbWholePlant.Image);
                plantEL.Plantflowerimage = methods.ConvertImageToByteArray(pbFlower.Image);
                plantEL.Plantleavesimage = methods.ConvertImageToByteArray(pbLeaves.Image);

                if (s.Equals("ADD"))
                {
                    plantEL.Plantid = 0;
                    ShowResult(plantBL.Insert(plantEL) > 0);
                }
                else if (s.Equals("EDIT"))
                {
                    ShowResult(plantBL.Update(plantEL));
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields marked by *");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CalculateAfterStopTypingDGV();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 | e.ColumnIndex == 1)
                plantEL.Plantid = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["plantid"].Value);
            if (e.ColumnIndex == 0)
            {
                s = "EDIT";
                ShowForm(true);
                lblHeader.Text = "Update Plant";

                plantEL = plantBL.Select(plantEL);

                txtCommonName.Text = plantEL.Plantcommonname;
                txtScientificName.Text = plantEL.Plantscientificname;
                txtFamily.Text = plantEL.Plantfamily;
                txtPlantMorphology.Text = plantEL.Plantmorphology;
                txtEconomicImportance.Text = plantEL.Planteconomicimportance;

                if (plantEL.Plantwholeimage.Length != 0)
                {
                    pbWholePlant.Image = methods.ConverteByteArrayToImage(plantEL.Plantwholeimage);
                }

                if (plantEL.Plantleavesimage.Length != 0)
                {
                    pbLeaves.Image = methods.ConverteByteArrayToImage(plantEL.Plantleavesimage);
                }

                if (plantEL.Plantflowerimage.Length != 0)
                {
                    pbFlower.Image = methods.ConverteByteArrayToImage(plantEL.Plantflowerimage);
                }


            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this selected item?", "Deleting", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ShowResult(plantBL.Delete(plantEL));
                }
            }
        }
    }
}
