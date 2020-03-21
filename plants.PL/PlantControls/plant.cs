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
    public partial class plant : UserControl
    {
        public plant()
        {
            InitializeComponent();
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

        
        private string plantName;
        private string plantScientificName;
        private Image plantImage;
        private int plantid;

        public string PlantName { get => plantName; set { plantName = value; lblPlantName.Text = value; } }
        public string PlantScientificName { get => plantScientificName; set { plantScientificName = value; lblScientificName.Text = value; } }
        public Image PlantImage { get => plantImage; set { plantImage = value; pbImage.Image = value; } }
        public int Plantid { get => plantid; set => plantid = value; }

 
    }
}
