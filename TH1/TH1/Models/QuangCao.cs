using System;
using System.ComponentModel.DataAnnotations;

public class QuangCao
{
    [Key]
    public int STT { get; set; }  // Primary Key

    [Required]
    [MaxLength(200)]
    public string TenCongTy { get; set; }  // Required, max length 200 characters

    [MaxLength(20)]
    public string? HinhMinhHoa { get; set; }  // Nullable, max length 20 characters

    [MaxLength(100)]
    public string? Href { get; set; }  // Nullable, max length 100 characters

    public DateTime? NgayBatDau { get; set; }  // Nullable

    public DateTime? NgayHetHan { get; set; }  // Nullable
}
