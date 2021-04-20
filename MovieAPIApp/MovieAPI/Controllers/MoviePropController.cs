using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Entities;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MoviePropController : ControllerBase
    {
        private readonly IMoviePropService _moviePropService;

        public MoviePropController(IMoviePropService moviePropService)
        {
            _moviePropService = moviePropService;
        }

        [HttpGet("GetMovies")]
        public IEnumerable<MovieProp> GetMovies()
        {
            var movies = _moviePropService.GetMovies();
            return movies;
        }

        [HttpGet("GetRandomMovie")]
        public MovieProp GetRandomMovie()
        {
            var randomMovie = _moviePropService.GetMovieById(new Random().Next(_moviePropService.GetMovies().Min(x => x.movieID), _moviePropService.GetMovies().Max(x => x.movieID)));

            if (randomMovie == null)
            {
                do
                {
                    randomMovie = _moviePropService.GetMovieById(new Random().Next(_moviePropService.GetMovies().Min(x => x.movieID), _moviePropService.GetMovies().Max(x => x.movieID)));
                } while (randomMovie == null);
                return randomMovie;
            }
            else
            {
                return randomMovie;
            }

        }


    }
}
