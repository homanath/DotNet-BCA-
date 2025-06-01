using System.Reflection.Metadata;

namespace TestWebApp.Models
{
    public class UserList
    {
        public int userId { get; set; }
        public string userName { get; set; } = null!;
        public string LoginId { get; set; } = null!;

        public string LoginPassword { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
