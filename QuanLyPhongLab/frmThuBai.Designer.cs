namespace QuanLyPhongLab
{
    partial class frmThuBai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.txtDesFolder = new System.Windows.Forms.TextBox();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.btnDesFolder = new System.Windows.Forms.Button();
            this.btnThuBai = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thư mục nguồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thư mục đích";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(165, 47);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(308, 23);
            this.txtSourceFolder.TabIndex = 3;
            // 
            // txtDesFolder
            // 
            this.txtDesFolder.Location = new System.Drawing.Point(165, 135);
            this.txtDesFolder.Name = "txtDesFolder";
            this.txtDesFolder.Size = new System.Drawing.Size(308, 23);
            this.txtDesFolder.TabIndex = 4;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(514, 47);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSourceFolder.TabIndex = 5;
            this.btnSourceFolder.Text = "Browse";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // btnDesFolder
            // 
            this.btnDesFolder.Location = new System.Drawing.Point(514, 138);
            this.btnDesFolder.Name = "btnDesFolder";
            this.btnDesFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDesFolder.TabIndex = 6;
            this.btnDesFolder.Text = "Browse";
            this.btnDesFolder.UseVisualStyleBackColor = true;
            this.btnDesFolder.Click += new System.EventHandler(this.btnDesFolder_Click);
            // 
            // btnThuBai
            // 
            this.btnThuBai.Location = new System.Drawing.Point(265, 203);
            this.btnThuBai.Name = "btnThuBai";
            this.btnThuBai.Size = new System.Drawing.Size(75, 23);
            this.btnThuBai.TabIndex = 7;
            this.btnThuBai.Text = "Thu bài";
            this.btnThuBai.UseVisualStyleBackColor = true;
            this.btnThuBai.Click += new System.EventHandler(this.btnThuBai_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmThuBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThuBai);
            this.Controls.Add(this.btnDesFolder);
            this.Controls.Add(this.btnSourceFolder);
            this.Controls.Add(this.txtDesFolder);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThuBai";
            this.ShowInTaskbar = false;
            this.Text = "Chọn đường dẫn nguồn và đích";
            this.Load += new System.EventHandler(this.frmThuBai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.TextBox txtDesFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.Button btnDesFolder;
        private System.Windows.Forms.Button btnThuBai;
        private System.Windows.Forms.Button btnExit;
    }
}