using Movie.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Interface
{
    public interface IMoviePropService
    {
        void Add(MovieProp movie);
        void Delete(MovieProp movie);
        void Edit(MovieProp movie);
        MovieProp GetMovieById(int id);
        IEnumerable<MovieProp> GetMovies();
    }
}
