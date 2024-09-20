using Microsoft.EntityFrameworkCore;
using TH1.Models;

namespace TH1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<QuangCao> QuangCaos { get; set; }
        public DbSet<ThamDo> ThamDos { get; set; }
        public DbSet<CTThamDo> CTThamDos { get; set; }
        public DbSet<DonDatHang> DonDatHangs { get; set; }
        //public DbSet<CTDatHang> CTDatHangs { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<VietSach> VietSaches { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

    }

}
