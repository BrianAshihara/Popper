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
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


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
                config.CreateMap<Local, LocalModel>();
                config.CreateMap<Tecnico, TecnicoModel>();
                config.CreateMap<Chamado, ChamadoModel>()
                    .ForMember(d => d.idTecnico, d => d.MapFrom(x => x.Tecnico_idtecnico!.Id))
                    .ForMember(d => d.idUsuario, d => d.MapFrom(x => x.Usuario_idusuario!.Id))
                    .ForMember(d => d.idLocal, d => d.MapFrom(x => x.Local_idlocal!.Id))
                    .ForMember(d => d.idTipoChamado, d => d.MapFrom(x => x.TipoChamado_idtipochamado!.Id))
                    .ForMember(d => d.nome, d => d.MapFrom(x => x.Usuario_idusuario!.Nome))
                    .ForMember(d => d.tecnico, d => d.MapFrom(x => x.Tecnico_idtecnico!.Nome)); 
                config.CreateMap<TipoChamado, TipoChamadoModel>()
                    .ForMember(d => d.idTecnico, d => d.MapFrom(x => x.Tecnico_idtecnico!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }

}
