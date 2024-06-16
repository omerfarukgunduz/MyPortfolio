using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class About
	{
		[Key]
        public int AboutId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }

    }
}
