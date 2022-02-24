using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movieshop.API.ResponseModel;

namespace Movieshop.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class Moviecontroller : ControllerBase
    {
        List<MovieReponseModel> MovieList;
        public Moviecontroller()
        {
            MovieList = new List<MovieReponseModel>
        {
            new MovieReponseModel{ID = 1, Name = "Die Hard", Ratings = 3.5f},
            new MovieReponseModel{ID = 2, Name = "Fast and Furious", Ratings = 4f},
            new MovieReponseModel{ID = 3, Name = "Hobbit", Ratings = 4.5f}
        };
        }


        [Route("list")]
        public IActionResult Get()
        {
            return Ok(MovieList);
        }


        [Route("get/{id:min(1):max(100)}")]
        public IActionResult Get(int id)
        {
            return Ok(MovieList[id]);
        }

        [Route("name/{name}")]
        public IActionResult Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                return NoContent();
            return Ok(MovieList.Where(x => x.Name == name).FirstOrDefault());
        }
    }
}
