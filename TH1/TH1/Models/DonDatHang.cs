using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DonDatHang
{
    [Key]
    public int SoDH { get; set; }  // Primary Key

    // Foreign key
    public int MaKH { get; set; }
    [ForeignKey("MaKH")]
    public KhachHang KhachHang { get; set; }

    public DateTime NgayDH { get; set; }

    [Range(0, double.MaxValue)]
    public decimal TriGia { get; set; }  // Must be > 0

    public bool DaGiao { get; set; } = false;  // Default false

    public DateTime? NgayGiaoHang { get; set; }  // Nullable

    [MaxLength(50)]
    public string? TenNguoiNhan { get; set; }

    [MaxLength(50)]
    public string? DiaChiNhan { get; set; }

    [MaxLength(15)]
    public string? DienThoaiNhan { get; set; }

    public bool HTThanhToan { get; set; } = false;  // Default false

    public bool HTGiaoHang { get; set; } = false;  // Default false
}
