using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels
{
    public enum ClassroomType
    {
        LyThuyet,
        ThucHanh
    }
    public enum ClassroomStatus
    {
        DangSuDung,
        DangTrong,
        DangSuaChua
    }

    public class Classroom
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự tăng lên 1 khi thêm đối tượng
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public ClassroomType Type { get; set; }
        [Required]
        public ClassroomStatus Status { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
