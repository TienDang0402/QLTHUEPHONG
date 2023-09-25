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
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmPhong()
        {
            InitializeComponent();
        }
        PHONG _phong;
        bool _them;
        int _maphong;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            loadData();
            loadLP();
            loadTang();
            ShowHideControl(true);
            txtIdPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            ckTrangThai.Enabled = false;
            cbIdTang.Enabled = false;
            cbIdLoaiPhong.Enabled = false;
            clear();
        }
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
        void loadLP()
        {
            _phong = new PHONG();

            cbIdLoaiPhong.DataSource = _phong.LayMALP();

            cbIdLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cbIdLoaiPhong.ValueMember = "IDLOAIPHONG";
        }

        void loadTang()
        {
            _phong = new PHONG();

            cbIdTang.DataSource = _phong.LayTang();

            cbIdTang.DisplayMember = "TENTANG";
            cbIdTang.ValueMember = "IDTANG";
        }
        public void loadData()
        {
            gcDanhSachPhong.DataSource = _phong.getAll(); // dòng này lấy dữ liệu từ dataSource lên và hiển thị vào lưới 
            gvDanhSachPhong.OptionsBehavior.Editable = false; // dòng này có nghĩa không cho chỉnh sửa trên lưới
        }
        void clear()
        {
            txtIdPhong.Text = "";
            txtTenPhong.Text = "";
            ckTrangThai.Text = "";
            cbIdLoaiPhong.Text = "";
            cbIdTang.Text = "";

        }
        void Enable(bool t)
        {

            txtTenPhong.Enabled = t;
            ckTrangThai.Enabled = t;
            cbIdLoaiPhong.Enabled = t;
            cbIdTang.Enabled = t;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtTenPhong.Focus();
            txtTenPhong.Enabled = true;
            cbIdLoaiPhong.Enabled = true;
            cbIdTang.Enabled = true;
            ckTrangThai.Enabled = true;
            txtIdPhong.Focus();
            ShowHideControl(false);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text.Length == 0 || cbIdLoaiPhong.Text.Length == 0 || cbIdTang.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn phòng để sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                _them = false;
                txtIdPhong.Enabled = false;
                Enable(true);
                txtTenPhong.Focus();
                ShowHideControl(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIdPhong.Text.Length == 0 || txtTenPhong.Text.Length == 0 || cbIdLoaiPhong.Text.Length == 0 || cbIdTang.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn phòng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    for (int i = 0; i < gvDanhSachPhong.RowCount; i++)
                    {
                        bool mutiselect = gvDanhSachPhong.IsRowSelected(i);
                        if (mutiselect)
                        {
                            _phong.deletePhong(int.Parse(gvDanhSachPhong.GetRowCellValue(i, "IDPHONG").ToString()));
                        }
                    }
            }
            loadData();
        }
    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // if này sẽ kiểm các giá trị trong các texbox đã nhập hay chưa nếu chưa nhập thì sẽ chạy cái if
            // và ngược lại đã nhập sẽ chạy cái else trong else sẽ chạy them = true hoặc them = false. Khi thêm bằng true sẽ chạy lưu khi thêm 1 phòng nào đó
            if (txtTenPhong.Text.Length == 0 || cbIdLoaiPhong.Text.Length == 0 || cbIdTang.Text.Length == 0)//|| ckTrangthai.Text.Length == 0) 
            {
                MessageBox.Show("Mời bạn nhập thông tin ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_Phong phog = new tb_Phong();
                        
                        phog.TENPHONG = txtTenPhong.Text;
                        phog.IDLOAIPHONG = int.Parse(cbIdLoaiPhong.SelectedValue.ToString());
                        phog.IDTANG = int.Parse(cbIdTang.SelectedValue.ToString());
                        phog.TRANGTHAI = ckTrangThai.Checked;

                        for (int i = 0; i < gvDanhSachPhong.RowCount; i++)
                        {
                            if (gvDanhSachPhong.GetRowCellValue(i, "TENPHONG").ToString() == txtTenPhong.Text)
                            {
                                MessageBox.Show("Tên Phòng đã có mời nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                                txtTenPhong.Text = "";
                                txtTenPhong.Focus();
                                return;
                            }
                        }
                        _phong.addPhong(phog);
                        txtIdPhong.Enabled = false;
                        txtTenPhong.Enabled = false;
                        cbIdLoaiPhong.Enabled = false;
                        cbIdTang.Enabled = false;
                        ckTrangThai.Enabled = false;
                        clear();
                    }
                    else
                    {
                        txtIdPhong.Focus();
                        return;
                    }

                }
                // else này khi them = false sẽ thực hiện lưu dữ liệu khi sửa
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _maphong = int.Parse(gvDanhSachPhong.GetRowCellValue(gvDanhSachPhong.FocusedRowHandle, "IDPHONG").ToString());

                        tb_Phong phog = _phong.getItem(_maphong);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        phog.TENPHONG = txtTenPhong.Text;
                        phog.IDLOAIPHONG = int.Parse(cbIdLoaiPhong.SelectedValue.ToString());
                        phog.IDTANG = int.Parse(cbIdTang.SelectedValue.ToString());
                        _phong.updatePhong(phog);
                        txtTenPhong.Enabled = false;
                        cbIdLoaiPhong.Enabled=false;
                        cbIdTang.Enabled = false;
                        ckTrangThai.Enabled=false;
                        clear();
                    }
                    else
                    {
                        return;
                    }

                }
                _them = false;
                loadData();
                ShowHideControl(true);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua khi chưa lưu hoặc chỉnh sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _them = false;
                txtIdPhong.Enabled = false;
                txtTenPhong.Enabled = false;
                cbIdLoaiPhong.Enabled = false;
                cbIdTang.Enabled = false;
                ckTrangThai.Enabled = false;
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

        private void gvDanhSachPhong_Click(object sender, EventArgs e)
        {
            if (gvDanhSachPhong.RowCount > 0)
            {
                // getfocusedrowcellvalue để lấy dữ liệu ở lưới hiển thị lên các texbox
                txtIdPhong.Text = gvDanhSachPhong.GetFocusedRowCellValue("IDPHONG").ToString();
                txtTenPhong.Text = gvDanhSachPhong.GetFocusedRowCellValue("TENPHONG").ToString();
                
                if (gvDanhSachPhong.GetFocusedRowCellValue("TRANGTHAI").ToString() == "True")
                {
                    ckTrangThai.Checked = true;
                }
                else
                {
                    ckTrangThai.Checked = false;
                }
                tb_LoaiPhong lp = new PHONG().getTenLP(int.Parse(gvDanhSachPhong.GetFocusedRowCellValue("IDLOAIPHONG").ToString()));
                tb_Tang tang = new PHONG().getTang(int.Parse(gvDanhSachPhong.GetFocusedRowCellValue("IDTANG").ToString()));
                cbIdLoaiPhong.Text = lp.TENLOAIPHONG;
                cbIdTang.Text = tang.TENTANG;
            }
        }
    }
}