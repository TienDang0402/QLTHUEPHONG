using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        bool _them;
        void ShowHideControl(bool t)
        {
            //Visible làm ẩn các button khi cho button = !t
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            btnThoat.Visible = t;
        }
        void Enable(bool t)
        {
            cbKhachHang.Enabled = t;
            btnAddNew.Enabled = t;
            dtNgayDat.Enabled = t;
            dtNgayTra.Enabled = t;
            cbTrangThai.Enabled = t;
            numSoNguoi.Enabled = t;
        }
        void clear()
        {
            cbKhachHang.Text = "";
            cbTrangThai.Text = "";
            numSoNguoi.Text = "";
            
        }
        

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            ShowHideControl(true);
            Enable(false);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            ShowHideControl(false);
            clear();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
                _them = false;
                Enable(true);
                ShowHideControl(false);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (txtIdPhong.Text.Length == 0 || txtTenPhong.Text.Length == 0 || cbIdLoaiPhong.Text.Length == 0 || cbIdTang.Text.Length == 0)
            //{
            //    MessageBox.Show("Mời bạn chọn phòng để xóa", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //        for (int i = 0; i < gvDanhSachPhong.RowCount; i++)
            //        {
            //            bool mutiselect = gvDanhSachPhong.IsRowSelected(i);
            //            if (mutiselect)
            //            {
            //                _phong.deletePhong(int.Parse(gvDanhSachPhong.GetRowCellValue(i, "IDPHONG").ToString()));
            //            }
            //        }
            //}
            //loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua khi chưa lưu hoặc chỉnh sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _them = false;
                ShowHideControl(true);
                clear();
            }
            else
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}