using System.ComponentModel.DataAnnotations;

public class TacGia
{
    [Key]
    public int MaTG { get; set; } // Primary Key

    [Required]
    [MaxLength(50)]
    public string TenTG { get; set; }  // Required, max length of 50 characters

    [MaxLength(100)]
    public string? DiaChiTG { get; set; }  // Nullable

    [MaxLength(15)]
    public string? DienThoaiTG { get; set; }  // Nullable

    // Navigation property
    public ICollection<VietSach> VietSach { get; set; }
}
