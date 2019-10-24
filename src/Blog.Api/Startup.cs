using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Reflection;
using Sparrow.Stores.Mongo;
using Sparrow.Core.Mapping;
using Sparrow.Core;

namespace Blog.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 配置
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var assemblies = new Assembly[] { GetType().Assembly };

            services.AddAutoMapper(cfg =>
            {
                cfg.AppliyMapperConfigurations(assemblies);
            }, assemblies);

            services.AddLogging(
                builder => builder.AddConsole()
                );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API", Version = "v1" });

                c.IncludeXmlComments("Blog.Api.xml");
            });

            var iocBuilder = new ContainerBuilder();

            iocBuilder.Populate(services);

            iocBuilder.AddSparrow();

            iocBuilder.AddMongo(setting =>
            {
                var host = Configuration["MongoServer:Host"];
                var port = Configuration["MongoServer:Port"];

                setting.ClientSettings.Server = new MongoServerAddress(host, int.Parse(port));
                setting.DatabaseName = "blog";
            });

            return new AutofacServiceProvider(iocBuilder.Build());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(setup => setup.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1"));

            app.UseSparrow();

            app.UseMvc();
        }
    }
}
