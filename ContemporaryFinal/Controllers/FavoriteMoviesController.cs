using Microsoft.AspNetCore.Mvc;
using ContemporaryFinal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteMoviesController : ControllerBase
    {
        private static List<FavoriteMovie> _movies = new List<FavoriteMovie>()
        {
            new FavoriteMovie
            {
                Id = 1,
                MemberName = "Han",
                Title = "Coraline",
                Genre = "Animation",
                ReleaseYear = 2009,
                Rating = 9.5
            }
        };

        [HttpGet("{id?}")]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
                return Ok(_movies.Take(5));

            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Create(FavoriteMovie movie)
        {
            movie.Id = _movies.Max(x => x.Id) + 1;
            _movies.Add(movie);
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, FavoriteMovie updatedMovie)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            movie.Title = updatedMovie.Title;
            movie.Genre = updatedMovie.Genre;
            movie.ReleaseYear = updatedMovie.ReleaseYear;
            movie.Rating = updatedMovie.Rating;
            movie.MemberName = updatedMovie.MemberName;

            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            _movies.Remove(movie);
            return Ok();
        }
    }
}
