using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Feature
	{
		[Key]

		public int FeatureId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }

    }
}
