using plants.PL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plants.PL.Registrations
{
    public partial class frmPlant : Form
    {
        
    
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
            delay += 150;
            if (delayedCalculationThreadDGV != null && delayedCalculationThreadDGV.IsAlive)
                return;

            delayedCalculationThreadDGV = new Thread(() =>
            {
                while (delay >= 150)
                {
                    delay = delay - 150;
                    try
                    {
                        Thread.Sleep(150);
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
            methods.DGVBUTTONView(dgv);
        }

        private void PopulateDGV()
        {
            var dt = plantBL.List(plantcategoryEL.Plantcategoryid, txtSearch.Text);
            methods.LoadDGV(dgv, dt);
            lblNumberOfResults.Text = "Showing " + dt.Rows.Count + " item(s).";
        }






        public void ShowResult(bool bol)
        {
            if (bol)
            {
                MessageBox.Show("Success");
                PopulateDGV();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }


        private void frmPlantsList_Load(object sender, EventArgs e)
        {
            ManageDGV();
        }


    

   
 


 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CalculateAfterStopTypingDGV();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            plantEL.Plantid = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["plantid"].Value);

            if (e.ColumnIndex == 0)
            {
                var frm = new PL.Registrations.frmPlantCRUD("VIEW", plantEL, this, plantcategoryEL);
                frm.ShowDialog();
  
            }
       
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            var frm = new PL.Registrations.frmPlantCRUD("ADD", plantEL, this, plantcategoryEL);
            frm.ShowDialog();
        }
    }
}
