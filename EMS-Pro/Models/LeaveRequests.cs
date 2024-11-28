namespace EMSPro.Entities
{
    public class LeaveRequests
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int LeaveTypesId { get; set; }
        public string Reasons { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int TotalDays { get; set; }
        public LeaveStatus Satus { get; set; } = LeaveStatus.Pending; 

        public LeaveTypes LeaveTypes { get; set; }
        public Users Users { get; set; }

    }
    public enum LeaveStatus
    {
        Approved,
        Pending,
        Rejected
    }
}
