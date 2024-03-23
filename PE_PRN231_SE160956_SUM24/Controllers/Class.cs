using BussinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using PE_PRN231_SE160956_SUM24.Models;
using Repository.IRepository;

namespace PE_PRN231_SE160956_SUM24.Controllers
{
    [Route("odata/test")]
    public class Class : ODataController
    {

        private IStarRepository _starepository;
        private IMovieRepository _movieRepository;

        public Class(IStarRepository starepository, IMovieRepository movieRepository)
        {
            _starepository = starepository;
            _movieRepository = movieRepository;
        }

        [EnableQuery]
        [HttpGet]
        public Task<List<Star>> GetAll()
        {
            return Task.FromResult(_starepository.GetAll());
        }

        

    }
}
