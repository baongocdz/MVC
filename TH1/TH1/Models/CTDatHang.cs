using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class CTDatHang
{
    [Key, Column(Order = 0)]
    public int SoDH { get; set; }  // Primary Key (part 1)

    public int MaSach { get; set; }

    [Range(1, int.MaxValue)]
    public int SoLuong { get; set; }  // Must be > 0

    [Range(0, double.MaxValue)]
    public decimal DonGia { get; set; }  // Must be >= 0

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal ThanhTien => SoLuong * DonGia;  // Computed column

    // Navigation properties
    [ForeignKey("SoDH")]
    public DonDatHang DonDatHang { get; set; }

    [ForeignKey("MaSach")]
    public Sach Sach { get; set; }
}
