using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

public interface IMovies{
    Task<MovieItem> GetMovieItem();
}