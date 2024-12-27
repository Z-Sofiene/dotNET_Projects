using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
