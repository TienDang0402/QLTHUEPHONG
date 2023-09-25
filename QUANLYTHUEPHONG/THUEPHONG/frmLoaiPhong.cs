using BusinessLayer;
using DataLayer;
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
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        LOAIPHONG _loaiphong;
        bool _them;
        int _malp;


        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void loadData()
        {
            gcDanhSachLoaiPhong.DataSource = _loaiphong.getAll();// la lay dư lieu tu db len cai luoi
            gvDanhSachLoaiPhong.OptionsBehavior.Editable = false;

        }
        void clear()
        {
            txtIdLoaiPhong.Text = "";
            txtTenLoaiPhong.Text = "";
            txtDonGia.Text = "";
            txtSoNguoiO.Text = "";
            txtSoGiuong.Text = "";

        }
        void Enable(bool t)
        {

            txtTenLoaiPhong.Enabled = t;
            txtDonGia.Enabled = t;
            txtSoNguoiO.Enabled = t;
            txtSoGiuong.Enabled = t;
        }
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _loaiphong = new LOAIPHONG();
            loadData();
            showHideControl(true);
            Enable(false);
            txtIdLoaiPhong.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            Enable(true);
            txtTenLoaiPhong.Focus();
            showHideControl(false);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtIdLoaiPhong.Enabled = false;
            Enable(true);
            txtTenLoaiPhong.Focus();
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                for (int i = 0; i < gvDanhSachLoaiPhong.RowCount; i++) // dung de duyet tu đau tơi cuôi
                {
                    bool mutiselect = gvDanhSachLoaiPhong.IsRowSelected(i);
                    if (mutiselect)
                    {
                        _malp = int.Parse(gvDanhSachLoaiPhong.GetRowCellValue(i, "IDLOAIPHONG").ToString());
                        _loaiphong.deleteLP(_malp);
                    }
                }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiPhong.Text.Length == 0 || txtDonGia.Text.Length == 0||txtSoNguoiO.Text.Length==0||txtSoGiuong.Text.Length==0)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (_them == true)
                {
                    if (MessageBox.Show("Bạn có muốn lưu lại không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_LoaiPhong lp = new tb_LoaiPhong();
                        lp.TENLOAIPHONG = txtTenLoaiPhong.Text;
                        lp.DONGIA = int.Parse(txtDonGia.Text.ToString());
                        lp.SONGUOIO = int.Parse(txtSoNguoiO.Text.ToString());
                        lp.SOGIUONG = int.Parse(txtSoGiuong.Text.ToString());

                        _loaiphong = new LOAIPHONG();
                        for (int i = 0; i < gvDanhSachLoaiPhong.RowCount; i++)
                        {
                            if (gvDanhSachLoaiPhong.GetRowCellValue(i, "TENLOAIPHONG").ToString() == txtTenLoaiPhong.Text)
                            {
                                MessageBox.Show("Tên loại phòng đã tồn tại mời nhập tên khác", "Thông Báo", MessageBoxButtons.OK);
                                txtTenLoaiPhong.Text = "";
                                txtTenLoaiPhong.Focus();
                                return;
                            }
                        }
                        _loaiphong.addLP(lp);
                        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                        loadData();
                        txtIdLoaiPhong.Enabled = false;
                        showHideControl(true);
                        Enable(false);
                        clear();
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu lại không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _malp = int.Parse(gvDanhSachLoaiPhong.GetRowCellValue(gvDanhSachLoaiPhong.FocusedRowHandle, "IDLOAIPHONG").ToString());
                        tb_LoaiPhong lp = _loaiphong.getItem(_malp);
                        lp.TENLOAIPHONG = txtTenLoaiPhong.Text;
                        lp.DONGIA = int.Parse(txtDonGia.Text);
                        lp.SONGUOIO = int.Parse(txtSoNguoiO.Text);
                        lp.SOGIUONG = int.Parse(txtSoGiuong.Text);

                        _loaiphong = new LOAIPHONG();
                        _loaiphong.updateLP(lp);
                        MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        return;
                    }
                    _them = false;
                    loadData();
                    showHideControl(true);
                    txtIdLoaiPhong.Enabled = false;
                    Enable(false);
                    clear();
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                _them = false;
                showHideControl(true);
                Enable(false);
                txtIdLoaiPhong.Enabled = false;
            }
            else
                return;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();

            }
        }

        private void gvDanhSachLoaiPhong_Click(object sender, EventArgs e)
        {
            if (gvDanhSachLoaiPhong.RowCount > 0)
            {
                txtIdLoaiPhong.Text = gvDanhSachLoaiPhong.GetFocusedRowCellValue("IDLOAIPHONG").ToString();
                txtTenLoaiPhong.Text = gvDanhSachLoaiPhong.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                txtDonGia.Text = gvDanhSachLoaiPhong.GetFocusedRowCellValue("DONGIA").ToString();
                txtSoNguoiO.Text = gvDanhSachLoaiPhong.GetFocusedRowCellValue("SONGUOIO").ToString();
                txtSoGiuong.Text = gvDanhSachLoaiPhong.GetFocusedRowCellValue("SOGIUONG").ToString();

            }
        }
    }
}