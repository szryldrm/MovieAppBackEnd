using MovieAppBackEnd.Core.DataAccess;
using MovieAppBackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.DataAccess.Abstract
{
    public interface IMovieDal: IEntityRepositoryMongo<Movie>
    {
    }
}
