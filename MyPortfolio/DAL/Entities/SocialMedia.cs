using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class SocialMedia
	{
		[Key]

		public int SocialMediaId { get; set; }

		public string SocialMediaName { get; set; }
		public string SocialMediaUrl { get; set; }
		public string SocialMediaIcon { get; set; }
	}
}
