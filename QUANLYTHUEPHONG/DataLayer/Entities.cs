using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //[Serializable]
    //public partial class Entities
    //{
    //    private Entities(DbConnection connectionString, bool contextOwnsConnection =true)
    //        :base(connectionString, contextOwnsConnection) { }
    //    public static Entities CreateEntities(bool contextOwnsConnection =true)
    //    {
    //        //doc file connect
    //        BinaryFormatter bf = new BinaryFormatter();
    //        FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
    //        connect cp = (connect)bf.Deserialize(fs);

    //        //Decrypt noi dung
    //        string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
    //        string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
    //        string password = Encryptor.Decrypt(cp.password, "qwertyuiop", true);
    //        string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

    //        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    //        SqlConnectionStringBuilder sqlConnectionBuilder = new SqlConnectionStringBuilder();
    //        sqlConnectionBuilder.DataSource = servername;
    //        sqlConnectionBuilder.InitialCatalog = database;
    //        sqlConnectionBuilder.UserID = username;
    //        sqlConnectionBuilder.Password = password;

    //        string sqlConnectionString  = sqlConnectionBuilder.ConnectionString;

    //        EntityConnectionStringBuilder entityBuiler = new EntityConnectionStringBuilder();
    //        entityBuiler.Provider = "System.Data.SqlClient";
    //        entityBuiler.ProviderConnectionString = sqlConnectionString;
    //        entityBuiler.Metadata = @"res://*/KHACHSAN.csdl|res://*/KHACHSAN.ssdl|res://*/KHACHSAN.msl";

    //        EntityConnection connection = new EntityConnection(entityBuiler.ConnectionString);
    //        fs.Close();
    //        return new Entities(connection);

    //    }
    //}
    public partial class Entities : DbContext
    {
        public Entities(string connect)
            : base(connect) { }

        public DbSet<tb_CongTy> congty { get; set; }
        public DbSet<tb_DatPhong> datphong { get; set; }
        public DbSet<tb_DonVi> donvi { get; set; }
        public DbSet<tb_KhachHang> khachhang { get; set; }
        public DbSet<tb_LoaiPhong> loaiphong { get; set; }
        public DbSet<tb_Phong> phong { get; set; }
        public DbSet<tb_Phong_ThietBi> phong_thietbi { get; set; }
        public DbSet<tb_SanPham> sanpham { get; set; }
        public DbSet<tb_Tang> tang { get; set; }
        public DbSet<tb_ThietBi> thietbi { get; set; }
        public DbSet<tb_Users> users { get; set; }

        public DbSet<tb_DATPHONG_CHITIET> datphongchitiet { get; set; }
        public DbSet<tb_DatPhong_SanPham> datphongsanpham { get; set; }


    }
}
