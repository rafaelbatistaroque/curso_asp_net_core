using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace mod1_ativ1
{
    public class Startup
    {
        readonly IConfiguration _config;
        public Startup()
        {
            var diretorioRaizProjeto = Directory.GetCurrentDirectory();
            var construtorLeitura = new ConfigurationBuilder()
                .SetBasePath(diretorioRaizProjeto)
                .AddIniFile("data.ini");

            _config = construtorLeitura.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                foreach (var item in _config.AsEnumerable())
                {
                    await context.Response.WriteAsync($"{item.Key} {item.Value}\n");
                }
            });
        }
    }
}
