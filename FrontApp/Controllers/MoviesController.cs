using FrontApp.Business;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieWorld.Grpc;
using System.Collections.Generic;

namespace FrontApp.Controllers
{
    //[Authorize(Policy = "Bearer", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private IMovieCollection movieCollection;
        private IConfiguration configuration;
        private GrpcChannel CinemaWorldChannel;
        private GrpcChannel FilmWorldChannel;

        public MoviesController(IMovieCollection movieCollection, IConfiguration configuration)
        {
            this.movieCollection = movieCollection;
            this.configuration = configuration;
            CinemaWorldChannel = GrpcChannel.ForAddress(configuration.GetSection("FrontAppSettings").GetSection("CinemaWorldApiUrl").Value);
            FilmWorldChannel = GrpcChannel.ForAddress(configuration.GetSection("FrontAppSettings").GetSection("FilmWorldApiUrl").Value);
        }
        [HttpGet]
        public List<MovieWithSource> Get()
        {
            List<Movie> CinemaWorldMovieList = movieCollection.GetAllMovies(CinemaWorldChannel);
            List<Movie> FilmWorldMovieList = movieCollection.GetAllMovies(FilmWorldChannel);

            MovieWithSource CinemaWorldMovieListwithSource = new MovieWithSource();
            CinemaWorldMovieListwithSource.MovieList = CinemaWorldMovieList;
            CinemaWorldMovieListwithSource.Source = "CinemaWorld";

            List<MovieWithSource> listMovieListwithSource = new List<MovieWithSource>();
            listMovieListwithSource.Add(CinemaWorldMovieListwithSource);

            MovieWithSource FilmWorldMovieListwithSource = new MovieWithSource();
            FilmWorldMovieListwithSource.MovieList = FilmWorldMovieList;
            FilmWorldMovieListwithSource.Source = "FilmWorld";

            listMovieListwithSource.Add(FilmWorldMovieListwithSource);
            return listMovieListwithSource;

            // Get the token from the Authorization header 
            //var bearerToken = this.Request.Headers["Authorization"].ToString();
            // Put the names of all keys into a string array.
            //String[] arr1 = bearerToken.Keys;
            //if(validateTokenSuccess(this.Request))
        }
        [HttpGet("{byId}")]
        public Movie Get(int id, string source)
        {
            switch (source)
            {
                case "CinemaWorld":
                    {
                        return movieCollection.GetMovieById(CinemaWorldChannel, id);
                    }
                case "FilmWorld":
                    {
                        return movieCollection.GetMovieById(FilmWorldChannel, id);
                    }
            }
            return null;
        }
        public class MovieWithSource
        {
            public List<Movie> MovieList { get; set; }
            public string Source { get; set; }
        }
    }
}
