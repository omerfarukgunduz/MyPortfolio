using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Experience
	{
		[Key]

		public int ExperieceId { get; set; }
		public string Title { get; set; }
		public string Company { get; set; }

		public string Date { get; set; }
		public string Description { get; set; }

    }
}
