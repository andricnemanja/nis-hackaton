using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
	public class Driver
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public string CompanyName { get; set; }

		[Required]
		public string PhoneNumber { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public string DriverName { get; set; }

		[Required]
		public int PostalCode { get; set; }

		[Required]
		public string Place { get; set; }

		[Required]
		[MaxLength(6)]
		public string TaxiLicence { get; set; }

		[Required]
		[MaxLength(9)]
		public string NumberOfId { get; set; }

		[Required]
		public DriverStatus DriverStatus { get; set; }

		public bool SMSNotification { get; set; }

		public bool EmailNotification { get; set; }

		[Required]
		public FuelCombination FuelCombination { get; set; }
	}
}
