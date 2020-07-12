using System.ComponentModel.DataAnnotations.Schema;

namespace DBEntity
{
    [Table("Levels")]
    public class Level
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
