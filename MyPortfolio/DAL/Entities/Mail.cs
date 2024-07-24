using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities

{
	public class Mail
	{
		[Key]
		public int Id { get; set; }
		public string Name {  get; set; }
		public string SenderMail { get; set; }
		public string ReceiverMail { get; set; }
		public string Subject {  get; set; }
		public string Body { get; set; }

	}
}
