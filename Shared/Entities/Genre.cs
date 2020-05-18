using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp2.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "This field is required")]
        public string Name { get; set; }
    }
}