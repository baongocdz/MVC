using System.ComponentModel.DataAnnotations;

public class ChuDe
{
    [Key]
    public int MaCD { get; set; } // Primary Key

    [Required]
    [MaxLength(50)]
    public string TenChuDe { get; set; }  // Required, max length of 50 characters

    // Navigation property
    public ICollection<Sach> Saches { get; set; }
}
