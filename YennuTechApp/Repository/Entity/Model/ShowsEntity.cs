using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity.Model
{
    public class ShowsEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime ShowDate { get; set; }
        [Required]
        public DateTime ShowTime { get; set; }
        public DateTime CreatedDate { get; set; }


        public LocationEntity LocationId { get; set; }
        public ScreenEntity ScreenId { get; set; }
        public MovieEntity MovieId { get; set; }
    }
}
