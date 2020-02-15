using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace mod1_ativ2.Middlewares
{
    public class Saudacoes
    {
        private readonly RequestDelegate _next;

        public Saudacoes(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            context.Response.StatusCode = 400;

            if(!context.Request.Path.Equals("/saudacoes", StringComparison.Ordinal))
            {
                await context.Response.WriteAsync("Caminho invalido");
                return;
            }
            if (!context.Request.Method.Equals("GET"))
            {
                await context.Response.WriteAsync($"{context.Request.Method} Metodo nao suportado");
                return;
            }
            if(!context.Request.Query.Any() || string.IsNullOrEmpty(context.Request.Query["nomes"]))
            {

                await context.Response.WriteAsync("Consulta vazia ou invalida");
                return;
            }
            
            context.Response.StatusCode = 200;

            var nomes = context.Request.Query["nomes"].ToString().Split(",").ToList();
            var sb = new StringBuilder();

            nomes.ForEach(n => sb.Append($"Ola {n}{Environment.NewLine}"));
            await context.Response.WriteAsync(sb.ToString());

            return;
        }
    }

    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Saudacoes>();
        }
    }
}
