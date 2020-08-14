using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using MovieAppBackEnd.Business.Abstract;
using MovieAppBackEnd.Business.Concrete;
using MovieAppBackEnd.Core.Utilities.Interceptors;
using MovieAppBackEnd.DataAccess.Abstract;
using MovieAppBackEnd.DataAccess.Concrete;

namespace MovieAppBackEnd.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieManager>().As<IMovieService>();
            builder.RegisterType<EfMovieDal>().As<IMovieDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(
                    new ProxyGenerationOptions()
                    {
                        Selector = new AspectInterceptorSelector()
                    }).SingleInstance();
        }
    }
}
