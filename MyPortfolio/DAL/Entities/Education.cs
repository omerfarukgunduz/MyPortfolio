using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
	public class Education
	{
		[Key]

		public int EducationId { get; set; }

		public string SchoolName { get; set;}
		public string Department { get; set;}

		public string Description { get; set;}	
    }
}
