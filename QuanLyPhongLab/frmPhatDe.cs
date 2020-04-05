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
    public partial class frmPhatDe : DevExpress.XtraEditors.XtraForm
    {
        public frmPhatDe()
        {
            InitializeComponent();
        }
        
        private void btndsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files |*.*|Text files |*.txt|Image files |*.png;*.jpeg;*jpg|Word Documents|*.doc;*.docx|Excel Worksheets |*.xls; *.xlsx|Archives Files|*.zip;*.rar";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbdsFile.Items.AddRange(openFile.FileNames);
            }
        }

        private void btnFolderDes_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục đích";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanDich.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private IEnumerable<DirectoryInfo> LayDanhSachThuMuc(IEnumerable<string> dsDuongDan)
        {
            return dsDuongDan
                .Select(duongDan => new DirectoryInfo(duongDan))
                .SelectMany(thuMuc => thuMuc.GetDirectories())
                .ToList();
        }
        private void btnPhatFile_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < lbdsFile.Items.Count; i++)
                {
                    string file = lbdsFile.Items[i].ToString();
                    List<string> listDuongDan = new List<string>();
                    listDuongDan.Add(txtDuongDanDich.Text);
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
                                File.Copy(file, Path.Combine(directoryInfo.FullName + "\\" + Path.GetFileName(file)), true);
                        }
                        else
                            break;
                    }
                }
                MessageBox.Show("Đã phát thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xãy ra" + ex.ToString(), "Thông báo", MessageBoxButtons.OKCancel);
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

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục đích";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = folderBrowserDialog.SelectedPath;
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
                System.IO.File.Copy(file, path,true);
            }
            string[] folders = Directory.GetDirectories(Source);
            foreach (string folder in folders)
            {
                string path = Path.Combine(Des, Path.GetFileName(folder));
                FoldertoFolder(folder, path);
            }
        }
       
        private void btnPhatFolder_Click(object sender, EventArgs e)
        {
            try
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
                                FoldertoFolder(txtSourceFolder.Text, directoryInfo.FullName);
                        }
                        else
                            break;
                       
                }
                    MessageBox.Show("Đã phát thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xãy ra" + ex.ToString(), "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void xóaFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbdsFile.Items.Remove(lbdsFile.SelectedItem);
        }

        private void frmPhatDe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}