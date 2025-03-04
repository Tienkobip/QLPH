using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels
{
    public enum ReportType
    {
        [Description("Bảo trì")]
        BaoTri,
        [Description("Phòng không sử dụng")]
        PhongKhongSuDung,
        [Description("Phòng thường gặp sự cố")]
        PhongThuongGapSuCo
    }
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public User User { get; set; }
        [Required]
        public ReportType Type { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
    }
}
