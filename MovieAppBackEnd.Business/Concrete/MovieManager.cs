using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using MovieAppBackEnd.Business.Abstract;
using MovieAppBackEnd.Business.Constants;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Caching;
using MovieAppBackEnd.Core.Utilities.Results;
using MovieAppBackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using MovieAppBackEnd.DataAccess.Abstract;
using MovieAppBackEnd.Core.Aspects.Autofac.Caching;
using MovieAppBackEnd.Core.Aspects.Autofac.Transaction;
using MovieAppBackEnd.Core.Aspects.Autofac.Logging;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace MovieAppBackEnd.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;
        private readonly ICacheManager _cacheManager;

        public MovieManager(IMovieDal movieDal, ICacheManager cacheManager)
        {
            _movieDal = movieDal;
            _cacheManager = cacheManager;
        }

        public IResult Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        [TransactionScopeAspect(Priority = 1)]
        [CacheAspect(duration: 60, Priority = 2)]
        [LogAspect(typeof(DatabaseLogger), Priority = 3)]
        public IDataResult<Movie> Get(string id)
        {
            var value = _movieDal.Get(Builders<Movie>.Filter.Eq("_id", new ObjectId(id)));

            return value != null
                ? (IDataResult<Movie>)new SuccessDataResult<Movie>(value)
                : new ErrorDataResult<Movie>(Messages.RecordIsNotFound);
        }

        [TransactionScopeAspect(Priority = 1)]
        [CacheAspect(duration: 60, Priority = 2)]
        [LogAspect(typeof(DatabaseLogger), Priority = 3)]
        public IDataResult<List<Movie>> GetList()
        {
            var value = _movieDal.GetList();

            return value != null
                ? (IDataResult<List<Movie>>)new SuccessDataResult<List<Movie>>(value)
                : new ErrorDataResult<List<Movie>>(Messages.ListNotFound);
        }

        public IResult Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
