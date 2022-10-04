using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShop.Web.Models.Base
{
    public class BaseEntity
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
    }
}
