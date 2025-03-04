using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels
{
    public enum NotificationType
    {
        [Description("Bảo trì")]
        BaoTri,
        [Description("Cập nhập dữ liệu")]
        CapNhapDuLieu,
        [Description("Xóa dữ liệu")]
        XoaDuLieu,
        [Description("cảnh báo phòng học")]
        CanhBaoPhongHoc
    }
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        [StringLength(500)]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public NotificationType Type { get; set; }


        [ForeignKey("UserID")]
        public virtual User User { get; set; }

    }
}
