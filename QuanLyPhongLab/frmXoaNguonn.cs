using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace QuanLyPhongLab
{
    public partial class frmXoaNguonn : DevExpress.XtraEditors.XtraForm
    {
        public frmXoaNguonn()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceDelete.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = txtSourceDelete.Text;
                var result = MessageBox.Show("Bạn có muốn xóa " + txtSourceDelete.Text.ToString(), "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                else
                {
                    Directory.Delete(folderPath, true);
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        private void frmXoaNguonn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}