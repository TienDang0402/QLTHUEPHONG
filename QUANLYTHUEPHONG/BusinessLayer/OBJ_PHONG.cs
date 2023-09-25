using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_PHONG
    {
        Entities db;
        public OBJ_PHONG()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }

        public int IDPHONG {  get; set; }
        public string TENPHONG { get; set; }
        public bool TRANGTHAI { get; set; }
        public int IDTANG { get; set; }
        public string TENTANG { get; set; }
        public double DONGIA {  get; set; }

        public int IDLOAIPHONG { get; set; }
        public string TENLOAIPHONG { get; set; }
        public bool DISABLED { get; set; }

        public OBJ_PHONG getItemFull(int id)
        {
            var _p = db.tb_Phong.FirstOrDefault(x=>x.IDPHONG==id);
            var tang = db.tb_Tang.FirstOrDefault(x=>x.IDTANG==id);
            var loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == id);
            OBJ_PHONG phong  = new OBJ_PHONG();
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
    }

    
}
