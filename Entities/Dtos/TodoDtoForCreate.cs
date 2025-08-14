using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class TodoDtoForCreate
    {
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }
    }
}
