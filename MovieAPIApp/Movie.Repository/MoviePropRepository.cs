using Movie.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Movie.Data;
using Movie.Entities;
using System.Linq;

namespace Movie.Repository
{
    public class MoviePropRepository : IMoviePropRepository
    {
        private readonly DataContext _dataContext;

        public MoviePropRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(MovieProp movie)
        {
            _dataContext.Movies.Add(movie);
            _dataContext.SaveChanges();
        }

        public void Delete(MovieProp movie)
        {
            _dataContext.Movies.Remove(movie);
            _dataContext.SaveChanges();
        }

        public void Edit(MovieProp movie)
        {
            _dataContext.Movies.Update(movie);
            _dataContext.SaveChanges();
        }

        public MovieProp GetMovieById(int id)
        {
            var result = _dataContext.Movies.FirstOrDefault(x => x.movieID == id);
            return result;
        }

        public IEnumerable<MovieProp> GetMovies()
        {
            var result = _dataContext.Movies.AsEnumerable();
            return result;
        }
    }
}
