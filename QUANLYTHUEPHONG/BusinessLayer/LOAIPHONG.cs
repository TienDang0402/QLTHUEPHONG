using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAIPHONG
    {
        Entities db;

        public LOAIPHONG() 
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_LoaiPhong> getAll()
        {
            return db.tb_LoaiPhong.ToList();
        }
        public tb_LoaiPhong getItem(int MaLP)
        {
            return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == MaLP);
        }

        public void addLP(tb_LoaiPhong lp)
        {
            try
            {

                db.tb_LoaiPhong.Add(lp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("có lỗi trong quá trình xử lý" + ex.Message);

            }
        }


        public void updateLP(tb_LoaiPhong loaiphong)
        {
            try
            {
                tb_LoaiPhong _lp = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == loaiphong.IDLOAIPHONG);
                if (_lp != null)
                {
                    _lp.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
                    _lp.DONGIA = loaiphong.DONGIA;
                    _lp.SONGUOIO = loaiphong.SONGUOIO;
                    _lp.SOGIUONG = loaiphong.SOGIUONG;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void deleteLP(int MALP)
        {
            tb_LoaiPhong _lp = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == MALP);
            try
            {
                db.tb_LoaiPhong.Remove(_lp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
