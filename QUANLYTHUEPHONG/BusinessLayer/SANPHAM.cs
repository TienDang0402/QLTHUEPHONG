using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SANPHAM
    {
        Entities db;
        public SANPHAM()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_SanPham> getAll()
        {
            return db.tb_SanPham.ToList();
        }
    }
}
