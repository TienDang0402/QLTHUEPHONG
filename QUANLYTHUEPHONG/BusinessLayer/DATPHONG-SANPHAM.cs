using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DATPHONG_SANPHAM
    {
        Entities db;
        public DATPHONG_SANPHAM()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_DatPhong_SanPham> getAll()
        {
            return db.tb_DatPhong_SanPham.ToList();
        }

        public tb_DatPhong_SanPham getItem(int id)
        {
            return db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == id);
        }

        public void add(tb_DatPhong_SanPham dpsp)
        {
            try
            {
                db.tb_DatPhong_SanPham.Add(dpsp);
                db.SaveChanges();
            }
            catch(Exception ex) { 
                throw new Exception("có lỗi trong quá trình xử lý dữ liệu"+ex.Message);
            }
        }
        public void deleteAll(int iddp)
        {
            List<tb_DatPhong_SanPham> lstSp  = db.tb_DatPhong_SanPham.Where(x=>x.ID==iddp).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(lstSp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
