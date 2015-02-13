using Autofac;
using SimpleImplementationModel.EFImplementation;
using SimpleImplementationModel.Queries;

namespace SimpleImplementationModel.Boot
{
    public static class Startup
    {
        public static void Initialise(ContainerBuilder builder, string connectionStringName)
        {
            builder.Register(x => new PeopleDbContext(connectionStringName));
            builder.RegisterType<EfRegisterPersonQuery>().As<RegisterPersonQuery>();
            builder.RegisterType<EfGetPeopleByFirstNameQuery>().As<GetPeopleByFirstNameQuery>();
        }
    }
}