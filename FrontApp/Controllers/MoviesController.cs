using MovieWorld.Grpc;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieWorldAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        public IEnumerable<Movie> Get()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Movies.MoviesClient(channel);
            var reply = client.GetAll(new GetAllMoviesRequest());
            return reply.Movies;
        }
    }
}
