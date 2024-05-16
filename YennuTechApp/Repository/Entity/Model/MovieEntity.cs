using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity.Model
{
    public class MovieEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [MaxLength(500)]
        public string Directors { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Synopsis { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public AgeRestrictionEntity AgeRestrictionId { get; set; }
    }
}
