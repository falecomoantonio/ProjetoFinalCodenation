namespace WebApi.Models
{
    public class LogModel
    {
        public virtual long? Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual string Address { get; set; }
        public virtual long? LevelId { get; set; }
        public virtual string LevelName { get; set; }
        public virtual long? EnviromentId { get; set; }
        public virtual string EnviromentName { get; set; }
        public virtual long? UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual System.DateTime? CreatedAt { get; set; }
        public virtual System.DateTime? UpdatedAt { get; set; }
    }
}
