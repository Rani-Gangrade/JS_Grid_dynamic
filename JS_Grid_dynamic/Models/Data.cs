using System.ComponentModel.DataAnnotations;

namespace JS_Grid_dynamic.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
    }
}
