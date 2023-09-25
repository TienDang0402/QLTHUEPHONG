using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DATPHONG
    {
        Entities db;
        public DATPHONG() { 
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_DatPhong>getAll()
        {
            return db.tb_DatPhong.ToList();
        }

        public tb_DatPhong getItem(int id)
        {
            return db.tb_DatPhong.FirstOrDefault(x => x.ID == id);
        }
        public tb_DatPhong add(tb_DatPhong dp)
        {
            try
            {
                db.datphong.Add(dp);
                db.SaveChanges();
                return dp;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra" + ex.Message);
            }
        }

        public void updateDatPhong(tb_DatPhong _datphong)
        {
            tb_DatPhong datphong = db.tb_DatPhong.FirstOrDefault(x => x.ID == _datphong.ID);
            datphong.IDKH = _datphong.IDKH;
            datphong.IDPHONG = _datphong.IDPHONG;
            datphong.NGAYDAT = _datphong.NGAYDAT;
            datphong.NGAYTRA = _datphong.NGAYTRA;
            datphong.SONGUOIO = _datphong.SONGUOIO;
            datphong.UID = _datphong.UID;
            datphong.IDSP = _datphong.IDSP;
            datphong.MACTY = _datphong.MACTY;
            datphong.MADVI = _datphong.MADVI;
            datphong.STATUS = _datphong.STATUS;
            datphong.DISABLED = _datphong.DISABLED;
            datphong.THEODOAN = _datphong.THEODOAN;
            datphong.GHICHU = _datphong.GHICHU;
            datphong.CREATE_DATE = _datphong.CREATE_DATE;
            datphong.UPDATE_BY = _datphong.UPDATE_BY;
            datphong.UPDATE_DATE = _datphong.UPDATE_DATE;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void deletePhong(int id)
        {
            tb_Phong phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
            try
            {
                db.phong.Remove(phong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }
    }
}
