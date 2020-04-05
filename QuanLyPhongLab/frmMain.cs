using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongLab
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void barbtnPhatDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhatDe frm = new frmPhatDe();
            frm.ShowDialog();
        }

        private void barbtnThuBai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuBai frm = new frmThuBai();
            frm.ShowDialog();
        }

        private void btnXoaNguon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXoaNguonn frm = new frmXoaNguonn();
            frm.ShowDialog();
        }
    }
}
