using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Contact
	{
		[Key]

		public int ContactId { get; set; }

		public string NameSurname { get; set; }
		public string EMail { get; set; }
		public string Subject { get; set; }

		public string Message { get; set; }

		public DateTime SendDate { get; set; }

		public bool IsRead { get; set; }
	}
}
