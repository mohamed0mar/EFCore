namespace EFCore.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>(); // Navigation Property

        //Navigation Property Is ICollection 
    }
}