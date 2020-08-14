using MovieAppBackEnd.Core.Utilities.Results;
using MovieAppBackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Business.Abstract
{
    public interface IMovieService
    {
        IDataResult<Movie> Get(string id);
        IDataResult<List<Movie>> GetList();
        IResult Add(Movie movie);
        IResult Delete(string id);
        IResult Update(Movie movie);
    }
}
