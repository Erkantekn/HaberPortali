using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Microsoft.AspNetCore.Builder
{
    public static class WebServiceEndpoint
    {
        private static string BASEURL = "api";

        public static void MapWebService(this IEndpointRouteBuilder app)
        {
            //News
            app.MapGet($"{BASEURL}/news/{{id}}", async context => {
                long key = long.Parse(context.Request.RouteValues["id"] as string);
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                News p = data.News.Find(key);
                if (p == null)
                {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                }
                else
                {
                    context.Response.ContentType = "application/json";
                    await context.Response
                        .WriteAsync(JsonSerializer.Serialize<News>(p));
                }
            });

            app.MapGet(BASEURL+ "/news", async context => {
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonSerializer
                    .Serialize<IEnumerable<News>>(data.News));
            });

            app.MapPost(BASEURL+ "/news", async context => {
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                News p = await
                    JsonSerializer.DeserializeAsync<News>(context.Request.Body);
                await data.AddAsync(p);
                await data.SaveChangesAsync();
                context.Response.StatusCode = StatusCodes.Status200OK;
            });

            //Categories
            app.MapGet($"{BASEURL}/categories/{{id}}", async context => {
                int key = int.Parse(context.Request.RouteValues["id"] as string);
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                Category p = data.Categories.Find(key);
                if (p == null)
                {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                }
                else
                {
                    context.Response.ContentType = "application/json";
                    await context.Response
                        .WriteAsync(JsonSerializer.Serialize<Category>(p));
                }
            });

            app.MapGet(BASEURL + "/categories", async context => {
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonSerializer
                    .Serialize<IEnumerable<Category>>(data.Categories));
            });

            app.MapPost(BASEURL + "/categories", async context => {
                PortalDbContext data = context.RequestServices.GetService<PortalDbContext>();
                Category p = await
                    JsonSerializer.DeserializeAsync<Category>(context.Request.Body);
                await data.AddAsync(p);
                await data.SaveChangesAsync();
                context.Response.StatusCode = StatusCodes.Status200OK;
            });
        }
    }
}
