using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace words_api.Models
{
    [Table("word")]
    public class Word
    {
        [Key, Column("wordid", TypeName = "integer")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int WordId {get; set;}

        [Column("front", TypeName = "text"), MaxLength(128), Required]
        public string Front {get; set;}

        [Column("back", TypeName = "text"), MaxLength(128), Required]
        public string Back {get; set;}

        [Column("additional", TypeName = "text"), MaxLength(128)]
        public string Additional {get; set;}
        
        [Column("order", TypeName = "integer")]
        public int Order {get; set;}
    }
}