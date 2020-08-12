using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Caching;
using MovieAppBackEnd.Core.Utilities.Interceptors;
using MovieAppBackEnd.Core.Utilities.IoC;

namespace MovieAppBackEnd.Core.Aspects.Autofac.Caching
{
    public class CacheFlushAspect : MethodInterception
    {
        private ICacheManager _cacheManager;

        public CacheFlushAspect() => _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.Clear();
        }
    }
}
