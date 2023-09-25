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
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        public frmTang()
        {
            InitializeComponent();
        }
        TANG _tang;
        bool _them;
        int _matang;
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

        public void loadData()
        {
            gcDanhSachTang.DataSource = _tang.getAll(); // dòng này lấy dữ liệu từ dataSource lên và hiển thị vào lưới 
            gvDanhSachTang.OptionsBehavior.Editable = false; // dòng này có nghĩa không cho chỉnh sửa trên lưới
        }
        void clear()
        {
            txtIdTang.Text = "";
            txtTenTang.Text = "";
        }
        void Enable(bool t)
        {
            txtTenTang.Enabled = t;

        }
        private void frmTang_Load(object sender, EventArgs e)
        {
            _tang = new TANG();
            loadData();
            ShowHideControl(true);
            txtIdTang.Enabled = false;
            txtTenTang.Enabled = false;
            clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtTenTang.Focus();
            txtTenTang.Enabled = true;
            ShowHideControl(false);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenTang.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn tầng để sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                _them = false;
                txtIdTang.Enabled = false;
                Enable(true);
                txtTenTang.Focus();
                ShowHideControl(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIdTang.Text.Length == 0 || txtTenTang.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn tầng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    for (int i = 0; i < gvDanhSachTang.RowCount; i++)
                    {
                        bool mutiselect = gvDanhSachTang.IsRowSelected(i);
                        if (mutiselect)
                        {
                            _tang.deleteTang(int.Parse(gvDanhSachTang.GetRowCellValue(i, "IDTANG").ToString()));
                        }
                    }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTang.Text.Length == 0 )
            {
                MessageBox.Show("Mời bạn nhập thông tin ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_Tang tang = new tb_Tang();

                        tang.TENTANG = txtTenTang.Text;


                        for (int i = 0; i < gvDanhSachTang.RowCount; i++)
                        {
                            if (gvDanhSachTang.GetRowCellValue(i, "TENTANG").ToString() == txtTenTang.Text)
                            {
                                MessageBox.Show("Tên tầng đã có mời nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                                txtTenTang.Text = "";
                                txtTenTang.Focus();
                                return;
                            }
                        }
                        _tang.addTang(tang);
                        txtIdTang.Enabled = false;
                        txtTenTang.Enabled = false;
                        clear();
                    }
                    else
                    {
                        txtTenTang.Focus();
                        return;
                    }

                }
                // else này khi them = false sẽ thực hiện lưu dữ liệu khi sửa
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _matang = int.Parse(gvDanhSachTang.GetRowCellValue(gvDanhSachTang.FocusedRowHandle, "IDTANG").ToString());
                        tb_Tang tang = _tang.getItem(_matang);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        tang.TENTANG = txtTenTang.Text;
                        _tang.updateTang(tang);
                        txtTenTang.Enabled = false;
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
                txtIdTang.Enabled = false;
                txtTenTang.Enabled = false;
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

        private void gcDanhSachTang_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTang.RowCount > 0)
            {
                // getfocusedrowcellvalue để lấy dữ liệu ở lưới hiển thị lên các texbox
                txtIdTang.Text = gvDanhSachTang.GetFocusedRowCellValue("IDTANG").ToString();
                txtTenTang.Text = gvDanhSachTang.GetFocusedRowCellValue("TENTANG").ToString();
            }
        }
    }
}