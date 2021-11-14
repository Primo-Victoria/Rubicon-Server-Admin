using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rubicon_Admin.DataAccess.Croe.Models
{
    [Table("UserRole")]
    public class UserRoleRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}
