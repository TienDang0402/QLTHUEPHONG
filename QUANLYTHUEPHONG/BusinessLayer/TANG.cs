using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TANG
    {
        Entities db;
        public TANG()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_Tang>getAll()
        {
            return db.tb_Tang.ToList();
        }
        public tb_Tang getItem(int id)
        {
            return db.tb_Tang.FirstOrDefault(x => x.IDTANG == id);
        }
        public void addTang(tb_Tang _tang)
        {
            try
            {
                db.tb_Tang.Add(_tang);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void updateTang(tb_Tang _tang)
        {
            tb_Tang tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == _tang.IDTANG);
            tang.TENTANG = _tang.TENTANG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }

        public void deleteTang(int id)
        {
            tb_Tang tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == id);
            try
            {
                db.tb_Tang.Remove(tang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("co loi trong qua trinh xu ly du lieu" + ex.Message);
            }
        }
    }
}
