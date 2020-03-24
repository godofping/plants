using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace plants.PL.Registrations
{
    public partial class frmPlantAddEdit : Form
    {
        string oldWholePlant;
        string oldFlower;
        string oldLeaves;

        string s;
        string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\img\\";
        EL.Registrations.Plants plantEL;
        EL.Registrations.Plantcategories plantcategoryEL;

        BL.Registrations.Plants plantBL = new BL.Registrations.Plants();
        BL.Registrations.Plantcategories plantcategoryBL = new BL.Registrations.Plantcategories();
        PL.Registrations.frmPlant frmPlant;

        public frmPlantAddEdit(string _s, EL.Registrations.Plants _plantEL, PL.Registrations.frmPlant _frmPlant, EL.Registrations.Plantcategories _plantcategoryEL)
        {
            InitializeComponent();

            plantcategoryEL = _plantcategoryEL;
            frmPlant = _frmPlant;
            s = _s;

            if (s.Equals("ADD"))
            {
                lblHeader.Text = "Add Plant";

                plantEL = new EL.Registrations.Plants();

                oldFlower = path + "image-icon-png-8.png";
                plantEL.Plantflowerimage = oldFlower;

                oldWholePlant = path + "image-icon-png-8.png";
                plantEL.Plantwholeimage = oldWholePlant;

                oldLeaves = path + "image-icon-png-8.png";
                plantEL.Plantleavesimage = oldLeaves;

                pbWholePlant.Image = Image.FromFile(path + "image-icon-png-8.png");
                pbLeaves.Image = Image.FromFile(path + "image-icon-png-8.png");
                pbFlower.Image = Image.FromFile(path + "image-icon-png-8.png");

            }
            else if (s.Equals("EDIT"))
            {
                lblHeader.Text = "Update Plant";
                plantEL = plantBL.Select(_plantEL);

                txtCommonName.Text = plantEL.Plantcommonname;
                txtScientificName.Text = plantEL.Plantscientificname;
                txtFamily.Text = plantEL.Plantfamily;
                txtPlantMorphology.Text = plantEL.Plantmorphology;
                txtEconomicImportance.Text = plantEL.Planteconomicimportance;

                oldFlower = plantEL.Plantflowerimage;
                oldLeaves = plantEL.Plantleavesimage;
                oldWholePlant = plantEL.Plantwholeimage;


                pbWholePlant.Image = Image.FromFile(plantEL.Plantwholeimage);
                pbLeaves.Image = Image.FromFile(plantEL.Plantleavesimage);
                pbFlower.Image = Image.FromFile(plantEL.Plantflowerimage);


            }




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

        private void pbAddImageWholePlant_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                plantEL.Plantwholeimage = open.FileName;
                pbWholePlant.Image = new Bitmap(plantEL.Plantwholeimage);

            }
        }

        private void pbAddImageFlower_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                plantEL.Plantflowerimage = open.FileName;
                pbFlower.Image = new Bitmap(plantEL.Plantflowerimage);
            }
        }

        private void pbAddLeavesImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                plantEL.Plantleavesimage = open.FileName;
                pbLeaves.Image = new Bitmap(plantEL.Plantleavesimage);
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (methods.CheckRequiredTXT(txtCommonName, txtScientificName))
            {


                plantEL.Plantcategoryid = plantcategoryEL.Plantcategoryid;
                plantEL.Plantcommonname = txtCommonName.Text;
                plantEL.Plantscientificname = txtScientificName.Text;
                plantEL.Plantfamily = txtFamily.Text;
                plantEL.Plantmorphology = txtPlantMorphology.Text;
                plantEL.Planteconomicimportance = txtEconomicImportance.Text;


               

                if (plantEL.Plantwholeimage != path + "image-icon-png-8.png")
                {
                    if (plantEL.Plantwholeimage != oldWholePlant)
                    {
                        plantEL.Plantwholeimage = methods.CopyFile(plantEL.Plantwholeimage, path, methods.RandomString(20));
                    } 
                }
                else
                {
                    plantEL.Plantwholeimage = oldWholePlant;
                }


                if (plantEL.Plantflowerimage != path + "image-icon-png-8.png")
                {
                    if (plantEL.Plantflowerimage != oldFlower)
                    {
                        plantEL.Plantflowerimage = methods.CopyFile(plantEL.Plantflowerimage, path, methods.RandomString(20));
                    }
                }
                else
                {
                    plantEL.Plantflowerimage = oldFlower;
                }


                if (plantEL.Plantleavesimage != path + "image-icon-png-8.png")
                {
                    if (plantEL.Plantleavesimage != oldLeaves)
                    {
                        plantEL.Plantleavesimage = methods.CopyFile(plantEL.Plantleavesimage, path, methods.RandomString(20));
                    }

                }
                else
                {
                    plantEL.Plantleavesimage = oldLeaves;
                }



                if (s.Equals("ADD"))
                {
                    plantEL.Plantid = 0;
                    frmPlant.ShowResult(plantBL.Insert(plantEL) > 0);
                    this.Dispose();
                }
                else if (s.Equals("EDIT"))
                {
                    frmPlant.ShowResult(plantBL.Update(plantEL));
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields marked by *");
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
