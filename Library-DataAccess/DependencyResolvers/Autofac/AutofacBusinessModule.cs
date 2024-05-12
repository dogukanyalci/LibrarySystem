using Autofac;
using AutoMapper;
using Library_DataAccess.AutoMapper;
using Library_DataAccess.Services.Concrete;
using Library_DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Services
            
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BookRepository>().As<IBookRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GenreRepository>().As<IGenreRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PublisherRepository>().As<IPublisherRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            builder.RegisterInstance<IMapper>(mapper);

        }
    }
}
