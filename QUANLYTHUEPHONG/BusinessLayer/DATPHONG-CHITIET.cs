using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DATPHONG_CHITIET
    {
        Entities db;
        public DATPHONG_CHITIET()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public List<tb_DATPHONG_CHITIET> getAll()
        {
            return db.tb_DATPHONG_CHITIET.ToList();
        }

        public tb_DATPHONG_CHITIET getItem(int id)
        {
            return db.tb_DATPHONG_CHITIET.FirstOrDefault(x => x.IDDPCT == id);
        }
    }
}
