﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicon_Admin.DataAccess.Croe.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; } 
        public UserRoleRto Role { get; set; }
 
    }
}