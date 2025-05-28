using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqTest.Models
{
    [Table("userList")] // matches table name in SQL Server
    public class UserList
    {
        [Key]
        [Column("userId")]
        public int UserId { get; set; }

        [Column("userName")]
        public string UserName { get; set; } = string.Empty;

        [Column("loginId")]
        public string LoginId { get; set; } = string.Empty;

        [Column("loginPassword")]
        public string LoginPassword { get; set; } = string.Empty;

        [Column("isActive")]
        public bool IsActive { get; set; }
    }
}
