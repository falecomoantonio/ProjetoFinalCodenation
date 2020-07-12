
namespace WebApi.Models
{
    public class UserModel
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Username { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual string UpdatedAt { get; set; }
    }
}
