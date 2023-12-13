using AutoMapper;
using popper.app.Models;
using popper.domain.Base;
using popper.domain.Entities;
using popper.repository.Context;
using popper.repository.Repository;
using popper.service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using popper.app.Cadastros;
using System.Security.Cryptography.X509Certificates;

namespace popper.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static ServiceProvider ServicesProvider;
        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("../../../Config/DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Local>, BaseRepository<Local>>();
            Services.AddScoped<IBaseRepository<Chamado>, BaseRepository<Chamado>>();
            Services.AddScoped<IBaseRepository<Tecnico>, BaseRepository<Tecnico>>();
            Services.AddScoped<IBaseRepository<TipoChamado>, BaseRepository<TipoChamado>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Local>, BaseService<Local>>();
            Services.AddScoped<IBaseService<Chamado>, BaseService<Chamado>>();
            Services.AddScoped<IBaseService<Tecnico>, BaseService<Tecnico>>();
            Services.AddScoped<IBaseService<TipoChamado>, BaseService<TipoChamado>>();

            // Formulários
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroLocal, CadastroLocal>();
            Services.AddTransient<CadastroTecnico, CadastroTecnico>();
            Services.AddTransient<CadastroChamado, CadastroChamado>();


            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Local, LocalModel>()
                    .ForMember(d => d.nome, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.idUsuario, d => d.MapFrom(x => x.Usuario!.Id));
                config.CreateMap<Tecnico, TecnicoModel>();
                config.CreateMap<Chamado, ChamadoModel>()
                    .ForMember(d => d.idUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.nome, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.idTecnico, d => d.MapFrom(x => x.Tecnico!.Id))
                    .ForMember(d => d.tecnico, d => d.MapFrom(x => x.Tecnico!.Nome)); 
                config.CreateMap<TipoChamado, TipoChamadoModel>()
                    .ForMember(d => d.idTecnico, d => d.MapFrom(x => x.Tecnico!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }

}
