using Movie.Entities;
using Movie.Repository.Interface;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service
{
    public class MoviePropService : IMoviePropService
    {
        private readonly IMoviePropRepository _moviePropRepository;

        public MoviePropService(IMoviePropRepository moviePropRepository)
        {
            _moviePropRepository = moviePropRepository;
        }

        public void Add(MovieProp movie)
        {
            _moviePropRepository.Add(movie);
        }

        public void Delete(MovieProp movie)
        {
            _moviePropRepository.Delete(movie);
        }

        public void Edit(MovieProp movie)
        {
            _moviePropRepository.Edit(movie);
        }

        public MovieProp GetMovieById(int id)
        {
            var result = _moviePropRepository.GetMovieById(id);
            return result;
        }

        public IEnumerable<MovieProp> GetMovies()
        {
            var result = _moviePropRepository.GetMovies();
            return result;
        }
    }
}
