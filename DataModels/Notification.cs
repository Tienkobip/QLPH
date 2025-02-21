using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels
{
    public enum NotificationType
    {
        BaoTri,
        CapNhapDuLieu,
        XoaDuLieu,
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
