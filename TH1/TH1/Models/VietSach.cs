using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class VietSach
{
    [Key, Column(Order = 0)]
    public int MaTG { get; set; }  // Primary Key (part 1)

    public int MaSach { get; set; }  // Primary Key (part 2)

    [MaxLength(30)]
    public string VaiTro { get; set; }  // Max length 30 characters

    // Navigation properties
    [ForeignKey("MaTG")]
    public TacGia TacGia { get; set; }

    [ForeignKey("MaSach")]
    public Sach Sach { get; set; }
}
