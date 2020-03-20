using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plants.PL
{
    public partial class mainForm : Form
    {
        public mainForm()
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

        private void ChangePanelLocation(Panel x, Button y)
        {
            x.Height = y.Height;
            x.Top = y.Top;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void btnHerbs_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlSideBox, btnHerbs);
            var frm = new Registrations.frmPlant();
            methods.ChangePanelDisplay(frm, pnlMain);

            pleaseWait.Dispose();
        }

        private void btnShrubs_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlSideBox, btnShrubs);
            var frm = new Registrations.frmPlant();
            methods.ChangePanelDisplay(frm, pnlMain);

            pleaseWait.Dispose();
        }

        private void btnTrees_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlSideBox, btnTrees);
            var frm = new Registrations.frmPlant();
            methods.ChangePanelDisplay(frm, pnlMain);

            pleaseWait.Dispose();
        }

        private void btnGrasses_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlSideBox, btnGrasses);
            var frm = new Registrations.frmPlant();
            methods.ChangePanelDisplay(frm, pnlMain);

            pleaseWait.Dispose();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlSideBox, btnGrasses);
            var frm = new Registrations.frmPlant();
            methods.ChangePanelDisplay(frm, pnlMain);

            pleaseWait.Dispose();
        }
    }
}
