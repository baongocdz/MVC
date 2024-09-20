using System.ComponentModel.DataAnnotations;
namespace TH1.Models
{
    public class Admin
    {
        [Key]
        public int MaAdmin { get; set; }

        [StringLength(50)]
        public string? HoTenAdmin { get; set; }

        [StringLength(50)]
        public string? DiaChiAdmin { get; set; }

        [StringLength(10)]
        public string? DienThoaiAdmin { get; set; }

        [StringLength(15)]
        public string? TenDNAdmin { get; set; }

        [StringLength(15)]
        public string? MatKhauAdmin { get; set; }

        public DateTime? NgaySinhAdmin { get; set; }

        public bool GioiTinhAdmin { get; set; } = true;

        [StringLength(50)]
        public string? EmailAdmin { get; set; }

        public int QuyenAdmin { get; set; } = 1;
    }
}


