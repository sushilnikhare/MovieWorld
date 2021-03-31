using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FilmWorld.Models;
using Grpc.Core;
using MoviesDO;
using MovieWorld.Grpc;
namespace FilmWorld
{
    public class FilmWorldService : Movies.MoviesBase
    {
        private readonly IMapper _mapper;
        public FilmWorldService()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MovieDO, Movie>());
            _mapper = new Mapper(config);
        }
        public override async Task<GetAllMoviesResponse> GetAll(GetAllMoviesRequest request, ServerCallContext serverCallContext)
        {
            var response = new GetAllMoviesResponse();

            try
            {
                await using (var db = new MovieDOContext())
                {
                    var movie = db.Movies.Select(x => x).ToList();
                    response.Movies.Add(_mapper.Map<List<Movie>>(movie));
                }
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
            return response;
        }

        public override async Task<GetByMovieIdResponse> GetByMovieId(GetByMovieIdRequest request, ServerCallContext serverCallContext)
        {
            var response = new GetByMovieIdResponse();
            try
            {
                await using (var db = new MovieDOContext())
                {
                    var movie = db.Movies.Select(x => x).Where(y => y.MovieId.Equals(request.MovieId));
                    response.Movie = _mapper.Map<Movie>(movie.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
            return response;
        }
    }
}
