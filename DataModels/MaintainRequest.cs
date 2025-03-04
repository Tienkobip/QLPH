using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModels
{
    public enum IssueType
    {
        [Description("Hư hỏng thiết bị")]
        HuHongThietBi,
        [Description("Sự cố phòng học")]
        SuCoPhongHoc,
        [Description("Khác")]
        Khac
    }
    public enum IssueStatus
    {
        [Description("Chưa xử lý")]
        ChuaXuLy,
        [Description("Đang xử lý")]
        DangXuLy,
        [Description("Đã hoàn thành")]
        DaHoanThanh
    }

    public class MaintainRequest
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ClassroomID { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public IssueType IssueType { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public IssueStatus IssueStatus { get; set; } = IssueStatus.ChuaXuLy;

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        [ForeignKey("ClassroomID")]
        public virtual Classroom Classroom { get; set; }
 
    }
}
