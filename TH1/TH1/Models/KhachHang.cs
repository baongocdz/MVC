using System.ComponentModel.DataAnnotations;

public class KhachHang
{
    [Key]
    public int MaKH { get; set; }  // Primary Key

    [MaxLength(50)]
    public string? HoTenKH { get; set; }

    [MaxLength(50)]
    public string? DiaChiKH { get; set; }

    [MaxLength(10)]
    public string? DienThoaiKH { get; set; }

    [MaxLength(15)]
    public string? TenDN { get; set; }

    [MaxLength(15)]
    public string? MatKhau { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool GioiTinh { get; set; } = true;  // Default true (male)

    [MaxLength(50)]
    public string? Email { get; set; }

    public bool DaDuyet { get; set; } = false;  // Default false
}
