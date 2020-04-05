namespace QuanLyPhongLab
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnPhatDe = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnThuBai = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnXoaNguon = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtnPhatDe,
            this.barbtnThuBai,
            this.barbtnSetting,
            this.btnXoaNguon});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(991, 193);
            // 
            // barbtnPhatDe
            // 
            this.barbtnPhatDe.Caption = "Phát đề";
            this.barbtnPhatDe.Id = 1;
            this.barbtnPhatDe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnPhatDe.ImageOptions.Image")));
            this.barbtnPhatDe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnPhatDe.ImageOptions.LargeImage")));
            this.barbtnPhatDe.Name = "barbtnPhatDe";
            this.barbtnPhatDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnPhatDe_ItemClick);
            // 
            // barbtnThuBai
            // 
            this.barbtnThuBai.Caption = "Thu bài";
            this.barbtnThuBai.Id = 2;
            this.barbtnThuBai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnThuBai.ImageOptions.Image")));
            this.barbtnThuBai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnThuBai.ImageOptions.LargeImage")));
            this.barbtnThuBai.Name = "barbtnThuBai";
            this.barbtnThuBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnThuBai_ItemClick);
            // 
            // barbtnSetting
            // 
            this.barbtnSetting.Caption = "Cấu hình";
            this.barbtnSetting.Id = 4;
            this.barbtnSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSetting.ImageOptions.Image")));
            this.barbtnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnSetting.ImageOptions.LargeImage")));
            this.barbtnSetting.Name = "barbtnSetting";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnPhatDe);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnThuBai);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoaNguon);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Các tính năng";
            // 
            // btnXoaNguon
            // 
            this.btnXoaNguon.Caption = "Xóa Nguồn";
            this.btnXoaNguon.Id = 5;
            this.btnXoaNguon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNguon.ImageOptions.Image")));
            this.btnXoaNguon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNguon.ImageOptions.LargeImage")));
            this.btnXoaNguon.Name = "btnXoaNguon";
            this.btnXoaNguon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNguon_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 603);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình quản lý phòng Lab";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barbtnPhatDe;
        private DevExpress.XtraBars.BarButtonItem barbtnThuBai;
        private DevExpress.XtraBars.BarButtonItem barbtnSetting;
        private DevExpress.XtraBars.BarButtonItem btnXoaNguon;
    }
}

