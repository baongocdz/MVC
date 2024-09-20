using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sach
{
    [Key]
    public int MaSach { get; set; } // Primary Key

    [Required]
    [MaxLength(100)]
    public string TenSach { get; set; }  // Required, max length of 100 characters

    [MaxLength(50)]
    public string DonViTinh { get; set; } = "cuốn";  // Default value 'cuốn'

    [Range(0, double.MaxValue)]
    public decimal DonGia { get; set; }  // Money, must be >= 0

    public string? MoTa { get; set; }  // Nullable NTEXT equivalent

    [MaxLength(50)]
    public string? HinhMinhHoa { get; set; }  // Nullable

    // Foreign keys
    public int? MaCD { get; set; }  // Nullable foreign key
    [ForeignKey("MaCD")]
    public ChuDe? ChuDe { get; set; }  // Navigation property

    public int? MaNXB { get; set; }  // Nullable foreign key
    [ForeignKey("MaNXB")]
    public NhaXuatBan? NhaXuatBan { get; set; }  // Navigation property

    public DateTime? NgayCapNhat { get; set; }  // Nullable Date

    [Range(1, int.MaxValue)]
    public int SoLuongBan { get; set; }  // Must be > 0

    public int SoLanXem { get; set; } = 0;  // Default value 0
}
