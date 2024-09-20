using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH1.Models
{
    public class CTThamDo
    {
        [Key, Column(Order = 0)]
        public int MaCH { get; set; }  // Primary Key (part 1)

        public int STT { get; set; }  // Primary Key (part 2)

        [Required]
        [MaxLength(255)]
        public string NoiDungTraLoi { get; set; }  // Required, max length 255 characters

        public int SoLanBinhChon { get; set; } = 0;  // Default value 0

        // Navigation property
        [ForeignKey("MaCH")]
        public ThamDo ThamDo { get; set; }
    }
}

