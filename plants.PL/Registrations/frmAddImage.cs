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
    public partial class frmAddImage : Form
    {
        public frmAddImage()
        {
            InitializeComponent();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(f.FileName);
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {

        }
    }
}
