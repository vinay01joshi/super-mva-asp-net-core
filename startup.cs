using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace supermva
{
    public class Startup 
    {
        public void Configure(IApplicationBuilder app , ILoggerFactory loggerFactory , IHostingEnvironment env)
        {
            loggerFactory.AddConsole();          
            
            if(env.IsDevelopment())
            {                
                app.UseDeveloperExceptionPage();
                app.UseFileServer(enableDirectoryBrowsing: true);
            }        

            app.UseStaticFiles();
            //app.UseDefaultFiles();

             
            app.Run(async (context) =>{                
                await context.Response.WriteAsync("Hello Everyone!");
            });
        }
    }
}