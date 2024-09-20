using System.ComponentModel.DataAnnotations;

public class NhaXuatBan
{
    [Key]
    public int MaNXB { get; set; } // Primary Key

    [Required]
    [MaxLength(100)]
    public string TenNXB { get; set; }  // Required, max length of 100 characters

    [MaxLength(150)]
    public string? DiaChi { get; set; }  // Nullable

    [MaxLength(15)]
    public string? DienThoai { get; set; }  // Nullable

    // Navigation property
    public ICollection<Sach> Saches { get; set; }
}
