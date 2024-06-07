using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity.Model
{
    public class MovieGenresEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public MovieEntity MovieId { get; set; }
        public GenresEntity GenderId { get; set; }
    }
}
