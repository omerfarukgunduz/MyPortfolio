using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Project
	{
		[Key]

		public int ProjectId { get; set; }

		public string ProjectName { get; set; }

		public string ProjectDescription { get; set; }
		
		public string ProjectLink { get; set; }

		public string Projectİmage { get; set; }
		
	}
}
