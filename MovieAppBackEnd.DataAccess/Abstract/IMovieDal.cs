using MovieAppBackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using MovieAppBackEnd.Core.DataAccess;

namespace MovieAppBackEnd.DataAccess.Abstract
{
    public interface IMovieDal : IEntityRepositoryMongo<Movie>
    {
    }
}
