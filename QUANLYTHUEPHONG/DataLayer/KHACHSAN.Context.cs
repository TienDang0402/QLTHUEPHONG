﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_CongTy> tb_CongTy { get; set; }
        public virtual DbSet<tb_DonVi> tb_DonVi { get; set; }
        public virtual DbSet<tb_KhachHang> tb_KhachHang { get; set; }
        public virtual DbSet<tb_LoaiPhong> tb_LoaiPhong { get; set; }
        public virtual DbSet<tb_Phong_ThietBi> tb_Phong_ThietBi { get; set; }
        public virtual DbSet<tb_SanPham> tb_SanPham { get; set; }
        public virtual DbSet<tb_Tang> tb_Tang { get; set; }
        public virtual DbSet<tb_ThietBi> tb_ThietBi { get; set; }
        public virtual DbSet<tb_Users> tb_Users { get; set; }
        public virtual DbSet<tb_Func> tb_Func { get; set; }
        public virtual DbSet<tb_DatPhong> tb_DatPhong { get; set; }
        public virtual DbSet<tb_DatPhong_SanPham> tb_DatPhong_SanPham { get; set; }
        public virtual DbSet<tb_DATPHONG_CHITIET> tb_DATPHONG_CHITIET { get; set; }
        public virtual DbSet<tb_Phong> tb_Phong { get; set; }
    }
}
