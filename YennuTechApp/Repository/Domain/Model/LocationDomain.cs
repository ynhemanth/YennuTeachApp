using System.ComponentModel.DataAnnotations;

namespace Repository.Domain.Model
{
    public class LocationDomain
    {
        public int Id { get; set; }
                
        public string Name { get; set; }
                
        public string Code { get; set; }
                
        public DateTime CreatedDate { get; set; }
    }
}
