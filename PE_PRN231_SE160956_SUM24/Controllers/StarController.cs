using BussinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using PE_PRN231_SE160956_SUM24.Models;
using Repository.IRepository;

namespace PE_PRN231_SE160956_SUM24.Controllers
{
    [Route("api/star")]
    [ApiController]
    public class StarController : ControllerBase
    {
        private IStarRepository _starepository;
        private IMovieRepository _movieRepository;

        public StarController(IStarRepository starepository, IMovieRepository movieRepository)
        {
            _starepository = starepository;
            _movieRepository = movieRepository;
        }

        [HttpGet]
        [Route("getstars/{nationality}/{gender}")]
        public Task<List<StarModels>> GetByNationalityAndGender(string nationality, string gender)
        {
            var getAll = _starepository.GetAll();
            var maleCheck = false;
            if (gender.ToLower() == "male")
            {
                maleCheck = true;
            }
            else
            {
                maleCheck = false;
            }
            var result = getAll.Where(x => x.Nationality.ToLower() == nationality.ToLower() &&
                                           x.Male == maleCheck).ToList();
            var listResult = new List<StarModels>();
            foreach (var item in result)
            {
                var genderOfItem = "";
                if (item.Male == true)
                {
                    genderOfItem = "Male";
                }
                else
                {
                    genderOfItem = "Female";
                }
                var star = new StarModels()
                {
                    Male = item.Male,
                    Description = item.Description,
                    Dob = item.Dob,
                    DobString = item.Dob.Value.ToString("M/dd/yyyy"),
                    FullName = item.FullName,
                    Gender = genderOfItem,
                    Id = item.Id,
                    Nationality = item.Nationality,
                };
                listResult.Add(star);
            }
            return Task.FromResult(listResult);
        }

        [HttpGet]
        [Route("getstars/{id}")]
        public Task<StartModelIncludeMovie> GetStarById(int id)
        {
            var result = _starepository.GetStarByIdIncludeMovice(id);
            string genderOfItem = "";
            if (result.Male == true)
            {
                genderOfItem = "Male";
            }
            else
            {
                genderOfItem = "Female";
            }
            var movie = _movieRepository.GetAll();
            var star = new StartModelIncludeMovie()
            {
                Male = result.Male,
                Description = result.Description,
                Dob = result.Dob,
                DobString = result.Dob.Value.ToString("M/dd/yyyy"),
                FullName = result.FullName,
                Gender = genderOfItem,
                Id = result.Id,
                Nationality = result.Nationality,
            };
            star.Movies = new List<MovieModel>();
            foreach (var item in result.Movies)
            {
                var movieModel = new MovieModel
                {
                    Description = item.Description,
                    Director = item.Director,
                    DirectorId = item.DirectorId,
                    Id = item.Id,
                    Language = item.Language,
                    ProducerId = item.ProducerId,
                    ReleaseDate = item.ReleaseDate,
                    Title = item.Title,
                };
                star.Movies.Add(movieModel);
            }
            return Task.FromResult(star);
        }
    }
}
