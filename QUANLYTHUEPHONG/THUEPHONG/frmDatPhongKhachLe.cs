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
    public partial class frmDatPhongKhachLe : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhongKhachLe()
        {
            InitializeComponent();
        }
        bool _them;
        public int _idPhong;
        int _idDp;
        DATPHONG _datphong;
        DATPHONG_SANPHAM dpsp;
        DATPHONG_CHITIET dpct;
        OBJ_PHONG _phonghientai;
        PHONG _phong;
        SANPHAM _sanPham;
        KHACHHANG kh;

        List<OBJ_DPSP> lstDPSP; 
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void frmDatPhongKhachLe_Load(object sender, EventArgs e)
        {
            _datphong = new DATPHONG();
            dpct = new DATPHONG_CHITIET();
            dpsp = new DATPHONG_SANPHAM();
            _phong = new PHONG();
            _sanPham = new SANPHAM();
            lstDPSP = new List<OBJ_DPSP>();
            _phonghientai =  _phong.getItemFull(_idPhong);
            lbTenPhong.Text = _phonghientai.TENPHONG + " - Đơn giá:"+ _phonghientai.DONGIA.ToString("N0") +"VND";
            dtNgayDat.Value= DateTime.Now;
            dtNgayTra.Value= DateTime.Now.AddDays(1);
            cbTrangThai.DataSource = TRANGTHAI.getList();
            cbTrangThai.ValueMember = "_value";
            cbTrangThai.DisplayMember = "_display";
            numSoNguoi.Text = "1";
            cbKh.Text = "";
            loadKH(); 
            loadSP();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_DatPhong dp = new tb_DatPhong();
                tb_DATPHONG_CHITIET dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDAT = dtNgayDat.Value;
                dp.NGAYTRA = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(numSoNguoi.Value.ToString());
                dp.STATUS = bool.Parse(cbTrangThai.SelectedValue.ToString());
                dp.IDKH = int.Parse(cbKh.SelectedValue.ToString());
                dp.SOTIEN = double.Parse(txtThanhTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.DISABLED = false;
                dp.UID = 1;
                dp.CREATE_DATE = DateTime.Now;
                var _dp = _datphong.add(dp);
                _idDp = _dp.ID;
                

            }
        }
        void loadSP()
        {
            gcSanPham.DataSource = _sanPham.getAll();
            gvSanPham.OptionsBehavior.Editable = false;
        }
        void loadKH()
        {
            kh = new KHACHHANG();
            cbKh.DataSource = kh.getAll();
            cbKh.ValueMember = "IDKH";
            cbKh.DisplayMember = "HOTEN";

        }

        void loadDPSP()
        {
            List<OBJ_DPSP> lsDP = new List<OBJ_DPSP>();
            foreach(var item in lstDPSP)
            {
                lsDP.Add(item);
            }  
            gcSPDV.DataSource = lsDP;
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKh = new frmKhachHang();
            frmKh.ShowDialog();
        }



        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            if(_idPhong==0)
            {
                MessageBox.Show("Vui lòng chọn phòng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }  
            if(gvSanPham.GetFocusedRowCellValue("IDSP")!=null )
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idPhong;
                sp.TENPHONG = _phonghientai.TENPHONG;
                sp.DONGIA = float.Parse(gvSanPham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN =sp.DONGIA * sp.SOLUONG;
                foreach(var item in lstDPSP)
                {
                    if(item.IDSP==sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN =item.SOLUONG * item.DONGIA;
                        loadDPSP();
                    }
                }  
                lstDPSP.Add(sp);

            }
            loadDPSP();
            txtThanhTien.Text =(double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString())+_phonghientai.DONGIA).ToString("N0");
        }
    }
}