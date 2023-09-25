using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bindingSource = new BindingSource();
        private TANG tang;
        private FUNC func;
        private PHONG phong;
        GalleryItem item = null;

        public frmMain()
        {
            InitializeComponent();
            tang = new TANG();
        }
         void leftMenu()
        {
            int i =0;

            var _lsparent= func.getParent();
            foreach (var pr in _lsparent)
            {
                NavBarGroup navGroup = new NavBarGroup(pr.DESCRIPTION);
                navGroup.Tag = pr.FUNC_CODE;
                navGroup.Name = pr.FUNC_CODE;
                navGroup.ImageOptions.LargeImageIndex = i;
                i++;
                navMain.Groups.Add(navGroup);

                var _lsChild = func.getChild(pr.FUNC_CODE);
                foreach (var child in _lsChild)
                {
                    NavBarItem navBarItem = new NavBarItem(child.DESCRIPTION);
                    navBarItem.Tag = child.FUNC_CODE;
                    navBarItem.Name = child.FUNC_CODE;
                    navBarItem.ImageOptions.SmallImageIndex = 0;
                    navGroup.ItemLinks.Add(navBarItem);
                }
                navMain.Groups[navGroup.Name].Expanded = true;
            }
            
        }

        void showRom()
        {
            var lsTang = tang.getAll();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64,64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach (var item in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = item.TENTANG;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                List<tb_Phong> lsPhong =phong.getByTang(item.IDTANG);
                foreach (var _phong in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = _phong.TENPHONG;
                    gc_item.Value = _phong.IDPHONG;
                    if(_phong.TRANGTHAI==true)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    }
                    galleryItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tang = new TANG();
            func = new FUNC();
            phong = new PHONG();
            leftMenu();
            showRom();
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code =e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "CONGTY":

                    {
                        frmCongty frmCongty = new frmCongty();
                        frmCongty.ShowDialog();
                        break;
                    }

                case "DONVI":

                    {
                        frmDonvi frmDonvi = new frmDonvi();
                        frmDonvi.ShowDialog();
                        break;
                    }
                case "PHONG":

                    {
                        frmPhong frmPhong = new frmPhong();
                        frmPhong.ShowDialog();
                        break;
                    }
                case "LOAIPHONG":

                    {
                        frmLoaiPhong frmLoaiPhong = new frmLoaiPhong();
                        frmLoaiPhong.ShowDialog();
                        break;
                    }
                case "TANG":

                    {
                        frmTang frmTang = new frmTang();
                        frmTang.ShowDialog();
                        break;
                    }
                case "DATPHONGTHEODOAN":

                    {
                        frmDatPhong frmDatPhong = new frmDatPhong();
                        frmDatPhong.ShowDialog();
                        break;
                    }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo ribbonHit = gControl.CalcHitInfo(point);
            if (ribbonHit.InGalleryItem || ribbonHit.HitTest == RibbonHitTest.GalleryImage)
            {
                item = ribbonHit.GalleryItem;
            }

        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatPhongKhachLe frmDatPhongKhachLe = new frmDatPhongKhachLe();
            frmDatPhongKhachLe._idPhong =int.Parse(item.Value.ToString());
            frmDatPhongKhachLe.ShowDialog();
        }
    }
}