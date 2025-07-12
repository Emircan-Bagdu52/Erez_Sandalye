using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Product
    {
		[Key]
		public int ProductId { get; set; }

		[Required, MaxLength(200)]
		public string Title { get; set; }

		[MaxLength(2000)]
		public string? Description { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
	}
}
