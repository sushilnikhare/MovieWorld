using Grpc.Net.Client;
using MovieWorld.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrontApp.Business
{
    public interface IMovieCollection
    {
        public List<Movie> GetAllMovies(GrpcChannel _Channel);
        public Movie GetMovieById(GrpcChannel _Channel, int id);

    }
    public class MovieCollection : IMovieCollection
    {
        public List<Movie> GetAllMovies(GrpcChannel _Channel)
        {
            List<Movie> movies = new List<Movie>();
            if (_Channel != null)
            {
                var client = new Movies.MoviesClient(_Channel);
                var reply = client.GetAll(new GetAllMoviesRequest());
                movies = reply.Movies.ToList();
            }
            return movies;
        }
        public Movie GetMovieById(GrpcChannel _Channel, int id)
        {
            Movie movie = new();
            if (_Channel != null)
            {
                var client = new Movies.MoviesClient(_Channel);
                var reply = client.GetByMovieId(new GetByMovieIdRequest { MovieId = id });
                movie = reply.Movie;
            }
            return movie;
        }
    }    
}
