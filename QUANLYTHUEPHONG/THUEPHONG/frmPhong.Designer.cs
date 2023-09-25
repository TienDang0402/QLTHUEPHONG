namespace THUEPHONG
{
    partial class frmPhong
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
            this.gcDanhSachPhong = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_LOAI_PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_TANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbIdLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbIdTang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckTrangThai = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1049, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::THUEPHONG.Properties.Resources.icon_them;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::THUEPHONG.Properties.Resources.icon_sua;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::THUEPHONG.Properties.Resources.icon_xoa;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::THUEPHONG.Properties.Resources.icon_luu;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::THUEPHONG.Properties.Resources.icon_boqua;
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(60, 44);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.icon_Thoat2;
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
            this.toolStrip2.Size = new System.Drawing.Size(1049, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // gcDanhSachPhong
            // 
            this.gcDanhSachPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSachPhong.Location = new System.Drawing.Point(0, 72);
            this.gcDanhSachPhong.MainView = this.gvDanhSachPhong;
            this.gcDanhSachPhong.Name = "gcDanhSachPhong";
            this.gcDanhSachPhong.Size = new System.Drawing.Size(1049, 200);
            this.gcDanhSachPhong.TabIndex = 2;
            this.gcDanhSachPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachPhong});
            // 
            // gvDanhSachPhong
            // 
            this.gvDanhSachPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_PHONG,
            this.TEN_PHONG,
            this.TRANG_THAI,
            this.ID_LOAI_PHONG,
            this.ID_TANG});
            this.gvDanhSachPhong.GridControl = this.gcDanhSachPhong;
            this.gvDanhSachPhong.Name = "gvDanhSachPhong";
            this.gvDanhSachPhong.Click += new System.EventHandler(this.gvDanhSachPhong_Click);
            // 
            // ID_PHONG
            // 
            this.ID_PHONG.Caption = "ID PHÒNG";
            this.ID_PHONG.FieldName = "IDPHONG";
            this.ID_PHONG.MinWidth = 25;
            this.ID_PHONG.Name = "ID_PHONG";
            this.ID_PHONG.Visible = true;
            this.ID_PHONG.VisibleIndex = 0;
            this.ID_PHONG.Width = 94;
            // 
            // TEN_PHONG
            // 
            this.TEN_PHONG.Caption = "TÊN PHÒNG";
            this.TEN_PHONG.FieldName = "TENPHONG";
            this.TEN_PHONG.MinWidth = 25;
            this.TEN_PHONG.Name = "TEN_PHONG";
            this.TEN_PHONG.Visible = true;
            this.TEN_PHONG.VisibleIndex = 1;
            this.TEN_PHONG.Width = 94;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.Caption = "TRẠNG THÁI";
            this.TRANG_THAI.FieldName = "TRANGTHAI";
            this.TRANG_THAI.MinWidth = 25;
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.Visible = true;
            this.TRANG_THAI.VisibleIndex = 2;
            this.TRANG_THAI.Width = 94;
            // 
            // ID_LOAI_PHONG
            // 
            this.ID_LOAI_PHONG.Caption = "ID LOẠI PHÒNG";
            this.ID_LOAI_PHONG.FieldName = "IDLOAIPHONG";
            this.ID_LOAI_PHONG.MinWidth = 25;
            this.ID_LOAI_PHONG.Name = "ID_LOAI_PHONG";
            this.ID_LOAI_PHONG.Visible = true;
            this.ID_LOAI_PHONG.VisibleIndex = 3;
            this.ID_LOAI_PHONG.Width = 94;
            // 
            // ID_TANG
            // 
            this.ID_TANG.Caption = "ID TẦNG";
            this.ID_TANG.FieldName = "IDTANG";
            this.ID_TANG.MinWidth = 25;
            this.ID_TANG.Name = "ID_TANG";
            this.ID_TANG.Visible = true;
            this.ID_TANG.VisibleIndex = 4;
            this.ID_TANG.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbIdLoaiPhong);
            this.groupControl1.Controls.Add(this.cbIdTang);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTenPhong);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtIdPhong);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 272);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 249);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin phòng";
            // 
            // cbIdLoaiPhong
            // 
            this.cbIdLoaiPhong.FormattingEnabled = true;
            this.cbIdLoaiPhong.Location = new System.Drawing.Point(630, 99);
            this.cbIdLoaiPhong.Name = "cbIdLoaiPhong";
            this.cbIdLoaiPhong.Size = new System.Drawing.Size(178, 24);
            this.cbIdLoaiPhong.TabIndex = 3;
            // 
            // cbIdTang
            // 
            this.cbIdTang.FormattingEnabled = true;
            this.cbIdTang.Location = new System.Drawing.Point(630, 53);
            this.cbIdTang.Name = "cbIdTang";
            this.cbIdTang.Size = new System.Drawing.Size(178, 24);
            this.cbIdTang.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckTrangThai);
            this.groupBox1.Location = new System.Drawing.Point(133, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ckTrangThai
            // 
            this.ckTrangThai.AutoSize = true;
            this.ckTrangThai.Location = new System.Drawing.Point(88, 32);
            this.ckTrangThai.Name = "ckTrangThai";
            this.ckTrangThai.Size = new System.Drawing.Size(81, 20);
            this.ckTrangThai.TabIndex = 0;
            this.ckTrangThai.Text = "Có khách";
            this.ckTrangThai.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID LOẠI PHÒNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID TẦNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRẠNG THÁI";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(133, 99);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(267, 23);
            this.txtTenPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÊN PHÒNG";
            // 
            // txtIdPhong
            // 
            this.txtIdPhong.Location = new System.Drawing.Point(133, 56);
            this.txtIdPhong.Name = "txtIdPhong";
            this.txtIdPhong.Size = new System.Drawing.Size(267, 23);
            this.txtIdPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PHÒNG";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 521);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSachPhong);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachPhong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdLoaiPhong;
        private System.Windows.Forms.ComboBox cbIdTang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn ID_PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI;
        private DevExpress.XtraGrid.Columns.GridColumn ID_LOAI_PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TANG;
    }
}