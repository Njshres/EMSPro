using System.ComponentModel.DataAnnotations;

namespace EMSPro.Entities
{
    public class LeaveTypes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPaid { get; set; }
        public int Days { get; set; }
    }
}
