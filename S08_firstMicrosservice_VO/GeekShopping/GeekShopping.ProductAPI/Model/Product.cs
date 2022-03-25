using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    //Serve para fazer o binding entre o banco e a aplicação.
    //se a tebela chamasse produto, o class poderia ser Product em table = produto.
    //nesse caso a tabela se chamará Product também.
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        [Column("price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("category_name")]
        [StringLength(50)]
        public  string CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }

    }
}
