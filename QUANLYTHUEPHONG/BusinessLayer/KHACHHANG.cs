using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHACHHANG
    {
        Entities db;
        public KHACHHANG() { 
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_KhachHang> getAll()
        {
            return db.tb_KhachHang.ToList();
        }
        public tb_KhachHang getItem(int id)
        {
            return db.tb_KhachHang.FirstOrDefault(x => x.IDKH == id);
        }
        public void addKH(tb_KhachHang kh)
        {
            try
            {
                db.tb_KhachHang.Add(kh);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void updateKH(tb_KhachHang kh)
        {
            tb_KhachHang khachhang = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == kh.IDKH);
            khachhang.HOTEN = kh.HOTEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void deleteKH(int id)
        {
            tb_KhachHang khachhang = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == id);
            try
            {
                db.tb_KhachHang.Remove(khachhang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }
    }
}
