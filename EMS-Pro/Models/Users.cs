using System.ComponentModel.DataAnnotations;

namespace EMSPro.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int LeaveTaken { get; set; }
        public int RemainingLeaves { get; set; }

    }
}
