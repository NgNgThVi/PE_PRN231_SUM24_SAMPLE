using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;

namespace PE_PRN231_SE160956_SUM24.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IGenreRepository _genreRepository;
        private IMovieRepository _movieRepository;

        public MovieController(IGenreRepository genreRepository, IMovieRepository movieRepository)
        {
            _genreRepository = genreRepository;
            _movieRepository = movieRepository;
        }

        [HttpDelete]
        [Route("removemoviefromgenre/{genreId}/{movieId}")]
        public ActionResult Delete(int genreId, int movieId)
        {
            var genre = _genreRepository.GetGenreByIdIncludeMovie(genreId);
            if (genre == null)
            {
                return NotFound("The requested genre could not be found.");
            }

            var movice = genre.Movies.Where(x => x.Id == movieId).FirstOrDefault();

            if (movice == null)
            {
                return NotFound("The requested movie could not be found in the list of movies of the requested genre.");
            }

            _genreRepository.DeleteRelationship(genreId, movieId);

            return Ok();
        }
    }
}
