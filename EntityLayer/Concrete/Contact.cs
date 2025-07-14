using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }

		[MaxLength(250)]
		public string Address { get; set; }

		[MaxLength(20)]
		public string Phone { get; set; }

		[MaxLength(50)]
		public string Email { get; set; }

		[MaxLength(100)]
		public string InstagramUrl { get; set; }

		[MaxLength(100)]
		public string SahibindenUrl { get; set; }

		[MaxLength(500)]
		public string GoogleMapsEmbedUrl { get; set; }

		public bool IsActive { get; set; } = true;
	}
}
