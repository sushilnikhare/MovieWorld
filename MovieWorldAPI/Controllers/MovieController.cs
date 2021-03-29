//using CinemaWorld.Grpc;
//using Grpc.Net.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieWorldAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public IEnumerable<string> Index()
        {
            List<string> Movies = new List<string>();
            Movies.Add("ABCD");
            return Movies;
        }
        //public IEnumerable<Movie> Index()
        //{
        //    List<Movie> Movies = new List<Movie>();
        //    var channel = GrpcChannel.ForAddress("https://localhost:5001");
        //    var client = new Movies.MoviesClient(channel);
        //    var reply = client.GetAll(new GetAllMoviesRequest());
        //    return Movies;
        //}
    }
}
