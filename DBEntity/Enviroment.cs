using System.ComponentModel.DataAnnotations.Schema;

namespace DBEntity
{
    [Table("Enviroments")]
    public class Enviroment
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
