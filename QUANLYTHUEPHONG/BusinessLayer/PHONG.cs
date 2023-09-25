using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHONG
    {
        Entities db;
        public PHONG()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public OBJ_PHONG getItemFull(int id)
        {
            var _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
            var tang = db.tb_Tang.FirstOrDefault(y => y.IDTANG == _p.IDTANG);
            var loaiphong = db.tb_LoaiPhong.FirstOrDefault(m => m.IDLOAIPHONG == _p.IDLOAIPHONG);
            OBJ_PHONG phong = new OBJ_PHONG();
            phong.IDPHONG = _p.IDPHONG;
            phong.TENPHONG = _p.TENPHONG;
            phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
            phong.IDLOAIPHONG = _p.IDLOAIPHONG;
            phong.IDTANG = _p.IDTANG;
            phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
            phong.DISABLED = bool.Parse(_p.DISABLED.ToString());
            phong.TENTANG = tang.TENTANG;
            phong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
            phong.DONGIA = double.Parse(loaiphong.DONGIA.ToString());

            return phong;
        }
        public tb_Phong getItem(int id)
        {
            return db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
        }
        public List<tb_Phong>getAll()
        {
            return db.tb_Phong.ToList();
        }

        public List<tb_LoaiPhong> LayMALP()
        {
            return db.tb_LoaiPhong.ToList();
        }

        public List<tb_Tang> LayTang()
        {
            return db.tb_Tang.ToList();
        }
        public tb_LoaiPhong getTenLP(int idLP)
        {
            return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idLP);
        }
        public tb_Tang getTang(int idTang)
        {
            return db.tb_Tang.FirstOrDefault(x => x.IDTANG == idTang);
        }
        public List<tb_Phong> getByTang(int idTang)
        {
            return db.tb_Phong.Where(x=>x.IDTANG == idTang).ToList();
        }

        public void addPhong(tb_Phong _phong)
        {
            try
            {
                db.tb_Phong.Add(_phong);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu"+ex.Message);
            }
        }

        public void updatePhong(tb_Phong _phong)
        {
            tb_Phong phong = db.tb_Phong.FirstOrDefault(x=>x.IDPHONG == _phong.IDPHONG);
            phong.TENPHONG = _phong.TENPHONG;
            phong.TRANGTHAI = _phong.TRANGTHAI;
            phong.IDTANG = _phong.IDTANG;
            phong.IDLOAIPHONG = _phong.IDLOAIPHONG;
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void deletePhong(int id)
        {
            tb_Phong phong =db.tb_Phong.FirstOrDefault( x=>x.IDPHONG == id);
            try
            {
                db.phong.Remove(phong);
                db.SaveChanges();
            }
            catch (Exception ex )
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }
        public void updateTrangThai(int map, bool tt)
        {
            tb_Phong p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == map);
            p.TRANGTHAI = tt;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }


    }
}
