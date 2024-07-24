using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Token
	{

        [Key]
        public int Id { get; set; }
		public string OwnerName { get; set; }
		public string MailAddress { get; set; }
		public string Password { get; set; }
	}
}
