using MovieAppBackEnd.Core.DataAccess.EntityFramework;
using MovieAppBackEnd.Core.Settings;
using MovieAppBackEnd.DataAccess.Abstract;
using MovieAppBackEnd.Entities.Concrete;

namespace MovieAppBackEnd.DataAccess.Concrete
{
    public class EfMovieDal : EfEntityRepositoryBaseMongo<Movie>, IMovieDal
    {
        public EfMovieDal(IMongoDbSettings settings) : base(settings)
        {
        }
    }
}
