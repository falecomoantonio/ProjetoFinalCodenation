using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBEntity
{
    [Table("Users")]
    public class User
    {
        [Column("Id")]
        public virtual long? Id { get; set; }

        [Column("Name")]
        public virtual string Name { get; set; }

        [Column("Email")]
        public virtual string Email { get; set; }

        [Column("Password")]
        public virtual string Password { get; set; }

        [Column("Nickname")]
        public virtual string Username { get; set; }

        [Column("CreatedAt")]
        public virtual DateTime? CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public virtual DateTime? UpdatedAt { get; set; }
        public virtual string HashPassword { get { return ""; } }
    }
}
