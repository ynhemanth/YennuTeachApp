using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity.Model
{
    public class MovieGenderEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public MovieEntity MovieId { get; set; }
        public GenderEntity GenderId { get; set; }
    }
}
