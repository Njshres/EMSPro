using System.ComponentModel.DataAnnotations;

namespace EMSPro.Entities
{
    public class LeaveAllocations
    {
        [Key]
        public int Id { get; set; }
        public LeaveTypes LeaveTypeId { get; set; }
        public Users UserId { get; set; }
        public bool IsApproved { get; set; }
        public int TotalDays { get; set; }

    }
}
