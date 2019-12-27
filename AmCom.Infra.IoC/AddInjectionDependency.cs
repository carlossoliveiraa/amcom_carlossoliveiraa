using AmCom.Application.Interfaces;
using AmCom.Application.Services;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Domain.Interfaces.Services;
using AmCom.Domain.Services;
using AmCom.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AmCom.Infra.IoC
{
    public class AddInjectionDependency
    {
        public static void Register(IServiceCollection svcCollection)
        {
            //Aplication
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServiceAppBase<,>));
            svcCollection.AddScoped<IAlunoApp, AlunoApp>();
            svcCollection.AddScoped<IDisciplinaApp, DisciplinaApp>();

            //Doman
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IAlunoService, AlunoService>();
            svcCollection.AddScoped<IDisciplinaService, DisciplinaService>();

            //Repository
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IAlunoRepository, AlunoRepository>();
            svcCollection.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
        }
    }
}
