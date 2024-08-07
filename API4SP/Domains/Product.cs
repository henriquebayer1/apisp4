using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API4SP.Domains
{

    [Table(nameof(Product))]
    public class Product
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do produto e obrigatorio!")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "O preco do produto e obrigatorio!")]
        public decimal Price { get; set; }

    }
}
