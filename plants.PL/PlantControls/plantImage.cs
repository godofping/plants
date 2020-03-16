using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plants.PL.PlantControls
{
    public partial class plantImage : UserControl
    {
        public plantImage()
        {
            InitializeComponent();
        }

        private string description;
        private Image plantpicture;

        public string Description { get => description; set { description = value; lblDescription.Text = value; } }
        public Image Plantpicture { get => plantpicture; set { plantpicture = value; pbImage.Image = value; } }
    }
}
