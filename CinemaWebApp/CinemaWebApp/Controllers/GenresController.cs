
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Models;
using CinemaWebApp.Services;
using CinemaWebApp.Dtos;

namespace CinemaWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService genresService;

        public GenresController(IGenresService genresServ)
        {
            genresService = genresServ;
        }

        // GET: api/Genres
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await genresService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(GenreDto dto)
        {
            return Ok(await genresService.Add(new Genre { Name = dto.Name }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(byte id, [FromBody] GenreDto dto)
        {
            var genre = await genresService.GetById(id);
            if (genre == null) { return NotFound($"no genre was found with ID: {id}"); }
            genre.Name = dto.Name;
            return Ok(genresService.Update(genre));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(byte id)
        {
            var genre = await genresService.GetById(id);
            if (genre == null) { return NotFound($"no genre was found with ID: {id}"); }
            genresService.Delete(genre);
            return Ok(genre);
        }
    }
}
