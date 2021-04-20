using Movie.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository.Interface
{
    public interface IMoviePropRepository
    {
        void Add(MovieProp movie);
        void Delete(MovieProp movie);
        void Edit(MovieProp movie);
        MovieProp GetMovieById(int id);
        IEnumerable<MovieProp> GetMovies();
    }
}
