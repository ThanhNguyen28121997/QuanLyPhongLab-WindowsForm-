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
    public partial class frmThuBai : DevExpress.XtraEditors.XtraForm
    {
        public frmThuBai()
        {
            InitializeComponent();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục đích";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDesFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục đích";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDesFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private IEnumerable<DirectoryInfo> LayDanhSachThuMuc(IEnumerable<string> dsDuongDan)
        {
            return dsDuongDan
                .Select(duongDan => new DirectoryInfo(duongDan))
                .SelectMany(thuMuc => thuMuc.GetDirectories())
                .ToList();
        }
        private void btnThuBai_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    List<string> listDuongDan = new List<string>();
                    listDuongDan.Add(txtDesFolder.Text);
                    IEnumerable<DirectoryInfo> ds = LayDanhSachThuMuc(listDuongDan);
                    foreach (DirectoryInfo directoryInfo in ds)
                    {
                        string locFile = "System Volume Information";
                        string locFile1 = "$RECYCLE.BIN";
                        if (directoryInfo.ToString() != locFile)
                        {
                            if (directoryInfo.ToString() == locFile1)
                            {
                                continue;
                            }
                            else
                                FoldertoFolder(directoryInfo.FullName, txtSourceFolder.Text);
                        }
                        else
                            break;
                    }

                    MessageBox.Show("Thu bài thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra" + ex.ToString(), "Thông báo", MessageBoxButtons.OKCancel);
            }
        }
        public void FoldertoFolder(string Source, string Des)
        {
            if (!Directory.Exists(Des))
            {
                Directory.CreateDirectory(Des);
            }
            string[] files = Directory.GetFiles(Source);
            foreach (string file in files)
            {
                string path = Path.Combine(Des, Path.GetFileName(file));
                System.IO.File.Move(file, path);
            }
            string[] folders = Directory.GetDirectories(Source);
            foreach (string folder in folders)
            {
                string path = Path.Combine(Des, Path.GetFileName(folder));
                FoldertoFolder(folder, path);
            }
        }

        private void frmThuBai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}