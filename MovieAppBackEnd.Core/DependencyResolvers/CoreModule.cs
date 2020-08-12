using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Caching;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Caching.Redis;
using MovieAppBackEnd.Core.Utilities.IoC;

namespace MovieAppBackEnd.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        private IConfiguration _configuration;

        public CoreModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Load(IServiceCollection services)
        {
            services.AddSingleton<ICacheManager, RedisCacheManager>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
