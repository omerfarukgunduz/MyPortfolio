using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class DownloadCV
    {
        [Key]
        public int CVId { get; set; }

        public string DownloadUrl { get; set; } 

    }
}
