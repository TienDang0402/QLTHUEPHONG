namespace THUEPHONG
{
    partial class frmLoaiPhong
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.gcDanhSachLoaiPhong = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachLoaiPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_LOAI_PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOAI_PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DON_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_NGUOI_O = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_GIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSoNguoiO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLoaiPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoQua,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::THUEPHONG.Properties.Resources.icon_them1;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::THUEPHONG.Properties.Resources.icon_sua1;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::THUEPHONG.Properties.Resources.icon_xoa1;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::THUEPHONG.Properties.Resources.icon_luu1;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::THUEPHONG.Properties.Resources.icon_boqua1;
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(60, 44);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.icon_Thoat3;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 47);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(892, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // gcDanhSachLoaiPhong
            // 
            this.gcDanhSachLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSachLoaiPhong.Location = new System.Drawing.Point(0, 78);
            this.gcDanhSachLoaiPhong.MainView = this.gvDanhSachLoaiPhong;
            this.gcDanhSachLoaiPhong.Name = "gcDanhSachLoaiPhong";
            this.gcDanhSachLoaiPhong.Size = new System.Drawing.Size(892, 200);
            this.gcDanhSachLoaiPhong.TabIndex = 2;
            this.gcDanhSachLoaiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachLoaiPhong});
            // 
            // gvDanhSachLoaiPhong
            // 
            this.gvDanhSachLoaiPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_LOAI_PHONG,
            this.TEN_LOAI_PHONG,
            this.DON_GIA,
            this.SO_NGUOI_O,
            this.SO_GIUONG});
            this.gvDanhSachLoaiPhong.GridControl = this.gcDanhSachLoaiPhong;
            this.gvDanhSachLoaiPhong.Name = "gvDanhSachLoaiPhong";
            this.gvDanhSachLoaiPhong.Click += new System.EventHandler(this.gvDanhSachLoaiPhong_Click);
            // 
            // ID_LOAI_PHONG
            // 
            this.ID_LOAI_PHONG.Caption = "ID LOẠI PHÒNG";
            this.ID_LOAI_PHONG.FieldName = "IDLOAIPHONG";
            this.ID_LOAI_PHONG.MinWidth = 25;
            this.ID_LOAI_PHONG.Name = "ID_LOAI_PHONG";
            this.ID_LOAI_PHONG.Visible = true;
            this.ID_LOAI_PHONG.VisibleIndex = 0;
            this.ID_LOAI_PHONG.Width = 94;
            // 
            // TEN_LOAI_PHONG
            // 
            this.TEN_LOAI_PHONG.Caption = "TÊN LOẠI PHÒNG";
            this.TEN_LOAI_PHONG.FieldName = "TENLOAIPHONG";
            this.TEN_LOAI_PHONG.MinWidth = 25;
            this.TEN_LOAI_PHONG.Name = "TEN_LOAI_PHONG";
            this.TEN_LOAI_PHONG.Visible = true;
            this.TEN_LOAI_PHONG.VisibleIndex = 1;
            this.TEN_LOAI_PHONG.Width = 94;
            // 
            // DON_GIA
            // 
            this.DON_GIA.Caption = "ĐƠN GIÁ";
            this.DON_GIA.FieldName = "DONGIA";
            this.DON_GIA.MinWidth = 25;
            this.DON_GIA.Name = "DON_GIA";
            this.DON_GIA.Visible = true;
            this.DON_GIA.VisibleIndex = 2;
            this.DON_GIA.Width = 94;
            // 
            // SO_NGUOI_O
            // 
            this.SO_NGUOI_O.Caption = "SỐ NGƯỜI Ở";
            this.SO_NGUOI_O.FieldName = "SONGUOIO";
            this.SO_NGUOI_O.MinWidth = 25;
            this.SO_NGUOI_O.Name = "SO_NGUOI_O";
            this.SO_NGUOI_O.Visible = true;
            this.SO_NGUOI_O.VisibleIndex = 3;
            this.SO_NGUOI_O.Width = 94;
            // 
            // SO_GIUONG
            // 
            this.SO_GIUONG.Caption = "SỐ GIƯỜNG";
            this.SO_GIUONG.FieldName = "SOGIUONG";
            this.SO_GIUONG.MinWidth = 25;
            this.SO_GIUONG.Name = "SO_GIUONG";
            this.SO_GIUONG.Visible = true;
            this.SO_GIUONG.VisibleIndex = 4;
            this.SO_GIUONG.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSoNguoiO);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtSoGiuong);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.textBox3);
            this.groupControl1.Controls.Add(this.txtTenLoaiPhong);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtIdLoaiPhong);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 278);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(892, 177);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "THÔNG TIN LOẠI PHÒNG";
            // 
            // txtSoNguoiO
            // 
            this.txtSoNguoiO.Location = new System.Drawing.Point(413, 101);
            this.txtSoNguoiO.Name = "txtSoNguoiO";
            this.txtSoNguoiO.Size = new System.Drawing.Size(169, 23);
            this.txtSoNguoiO.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "SỐ NGƯỜI Ở";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(695, 60);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(149, 23);
            this.txtSoGiuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(413, 56);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(169, 23);
            this.txtDonGia.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "SỐ GIƯỜNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐƠN GIÁ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(413, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 23);
            this.textBox3.TabIndex = 1;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(129, 101);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(176, 23);
            this.txtTenLoaiPhong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÊN LOẠI PHÒNG";
            // 
            // txtIdLoaiPhong
            // 
            this.txtIdLoaiPhong.Location = new System.Drawing.Point(129, 56);
            this.txtIdLoaiPhong.Name = "txtIdLoaiPhong";
            this.txtIdLoaiPhong.Size = new System.Drawing.Size(176, 23);
            this.txtIdLoaiPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID LOẠI PHÒNG";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 446);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSachLoaiPhong);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại phòng";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSachLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachLoaiPhong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtSoNguoiO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLoaiPhong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_LOAI_PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOAI_PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DON_GIA;
        private DevExpress.XtraGrid.Columns.GridColumn SO_NGUOI_O;
        private DevExpress.XtraGrid.Columns.GridColumn SO_GIUONG;
    }
}