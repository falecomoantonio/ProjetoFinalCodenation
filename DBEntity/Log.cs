using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBEntity
{
    [Table("Logs")]
    public class Log
    {
        public virtual long? Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual string Address { get; set; }
        public virtual long? LevelId { get; set; }
        public virtual Level Level { get; set; }   
        public virtual long? EnviromentId { get; set; }
        public virtual Enviroment Enviroment { get; set; }
        public virtual long? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
    }
}
