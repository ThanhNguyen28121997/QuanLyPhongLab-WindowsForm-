namespace QuanLyPhongLab
{
    partial class frmPhatDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPhatFile = new System.Windows.Forms.Button();
            this.btnFolderDes = new System.Windows.Forms.Button();
            this.txtDuongDanDich = new System.Windows.Forms.TextBox();
            this.btndsFile = new System.Windows.Forms.Button();
            this.lbdsFile = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExitFolder = new System.Windows.Forms.Button();
            this.btnPhatFolder = new System.Windows.Forms.Button();
            this.btnDesFolder = new System.Windows.Forms.Button();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.txtDesFolder = new System.Windows.Forms.TextBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnPhatFile);
            this.tabPage1.Controls.Add(this.btnFolderDes);
            this.tabPage1.Controls.Add(this.txtDuongDanDich);
            this.tabPage1.Controls.Add(this.btndsFile);
            this.tabPage1.Controls.Add(this.lbdsFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phát theo File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPhatFile
            // 
            this.btnPhatFile.Location = new System.Drawing.Point(185, 172);
            this.btnPhatFile.Name = "btnPhatFile";
            this.btnPhatFile.Size = new System.Drawing.Size(75, 23);
            this.btnPhatFile.TabIndex = 6;
            this.btnPhatFile.Text = "Phát đề";
            this.btnPhatFile.UseVisualStyleBackColor = true;
            this.btnPhatFile.Click += new System.EventHandler(this.btnPhatFile_Click);
            // 
            // btnFolderDes
            // 
            this.btnFolderDes.Location = new System.Drawing.Point(502, 121);
            this.btnFolderDes.Name = "btnFolderDes";
            this.btnFolderDes.Size = new System.Drawing.Size(75, 23);
            this.btnFolderDes.TabIndex = 5;
            this.btnFolderDes.Text = "Browse";
            this.btnFolderDes.UseVisualStyleBackColor = true;
            this.btnFolderDes.Click += new System.EventHandler(this.btnFolderDes_Click);
            // 
            // txtDuongDanDich
            // 
            this.txtDuongDanDich.Location = new System.Drawing.Point(148, 121);
            this.txtDuongDanDich.Name = "txtDuongDanDich";
            this.txtDuongDanDich.Size = new System.Drawing.Size(338, 23);
            this.txtDuongDanDich.TabIndex = 4;
            // 
            // btndsFile
            // 
            this.btndsFile.Location = new System.Drawing.Point(502, 23);
            this.btndsFile.Name = "btndsFile";
            this.btndsFile.Size = new System.Drawing.Size(75, 23);
            this.btndsFile.TabIndex = 3;
            this.btndsFile.Text = "Browse";
            this.btndsFile.UseVisualStyleBackColor = true;
            this.btndsFile.Click += new System.EventHandler(this.btndsFile_Click);
            // 
            // lbdsFile
            // 
            this.lbdsFile.FormattingEnabled = true;
            this.lbdsFile.ItemHeight = 16;
            this.lbdsFile.Location = new System.Drawing.Point(148, 23);
            this.lbdsFile.Name = "lbdsFile";
            this.lbdsFile.Size = new System.Drawing.Size(338, 84);
            this.lbdsFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách File";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExitFolder);
            this.tabPage2.Controls.Add(this.btnPhatFolder);
            this.tabPage2.Controls.Add(this.btnDesFolder);
            this.tabPage2.Controls.Add(this.btnSourceFolder);
            this.tabPage2.Controls.Add(this.txtDesFolder);
            this.tabPage2.Controls.Add(this.txtSourceFolder);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phát theo Folder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExitFolder
            // 
            this.btnExitFolder.Location = new System.Drawing.Point(348, 165);
            this.btnExitFolder.Name = "btnExitFolder";
            this.btnExitFolder.Size = new System.Drawing.Size(75, 23);
            this.btnExitFolder.TabIndex = 7;
            this.btnExitFolder.Text = "Exit";
            this.btnExitFolder.UseVisualStyleBackColor = true;
            // 
            // btnPhatFolder
            // 
            this.btnPhatFolder.Location = new System.Drawing.Point(203, 165);
            this.btnPhatFolder.Name = "btnPhatFolder";
            this.btnPhatFolder.Size = new System.Drawing.Size(75, 23);
            this.btnPhatFolder.TabIndex = 6;
            this.btnPhatFolder.Text = "Phát đề";
            this.btnPhatFolder.UseVisualStyleBackColor = true;
            this.btnPhatFolder.Click += new System.EventHandler(this.btnPhatFolder_Click);
            // 
            // btnDesFolder
            // 
            this.btnDesFolder.Location = new System.Drawing.Point(499, 106);
            this.btnDesFolder.Name = "btnDesFolder";
            this.btnDesFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDesFolder.TabIndex = 5;
            this.btnDesFolder.Text = "Browse";
            this.btnDesFolder.UseVisualStyleBackColor = true;
            this.btnDesFolder.Click += new System.EventHandler(this.btnDesFolder_Click);
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(499, 31);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSourceFolder.TabIndex = 4;
            this.btnSourceFolder.Text = "Browse";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // txtDesFolder
            // 
            this.txtDesFolder.Location = new System.Drawing.Point(165, 106);
            this.txtDesFolder.Name = "txtDesFolder";
            this.txtDesFolder.Size = new System.Drawing.Size(308, 23);
            this.txtDesFolder.TabIndex = 3;
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(165, 32);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(308, 23);
            this.txtSourceFolder.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thư mục đích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thư mục nguồn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaFIleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 28);
            // 
            // xóaFIleToolStripMenuItem
            // 
            this.xóaFIleToolStripMenuItem.Name = "xóaFIleToolStripMenuItem";
            this.xóaFIleToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.xóaFIleToolStripMenuItem.Text = "Xóa FIle";
            this.xóaFIleToolStripMenuItem.Click += new System.EventHandler(this.xóaFIleToolStripMenuItem_Click);
            // 
            // frmPhatDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 273);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhatDe";
            this.ShowInTaskbar = false;
            this.Text = "Chọn đường dẫn nguồn và đích";
            this.Load += new System.EventHandler(this.frmPhatDe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbdsFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPhatFile;
        private System.Windows.Forms.Button btnFolderDes;
        private System.Windows.Forms.TextBox txtDuongDanDich;
        private System.Windows.Forms.Button btndsFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.TextBox txtDesFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnExitFolder;
        private System.Windows.Forms.Button btnPhatFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaFIleToolStripMenuItem;
    }
}