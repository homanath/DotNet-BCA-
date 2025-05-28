namespace TestWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly JoinDate { get; set; }
        // Constructor
        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Address = string.Empty;
            JoinDate = DateOnly.MinValue;
        }
    }
}
