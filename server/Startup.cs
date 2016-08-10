using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Nancy.Owin;

namespace anemone
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
            /*app.Run(context =>
            {
                return context.Response.WriteAsync("Hello from ASP.NET Core!");
            });*/
        }
    }
}