//using LyThuyet.Models;
using System;
using System.ComponentModel.DataAnnotations;
using TH1.Models;


public class ThamDo
{
    [Key]
    public int MaCH { get; set; }  // Primary Key

    public DateTime? NgayDang { get; set; }  // Nullable

    [Required]
    [MaxLength(255)]
    public string NoiDungThamDo { get; set; }  // Required, max length 255 characters

    public int TongSoBinhChon { get; set; } = 0;  // Default value 0

    // Navigation property
    public ICollection<CTThamDo> CTThamDos { get; set; }
}
