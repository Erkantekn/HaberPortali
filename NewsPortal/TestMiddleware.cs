using Microsoft.AspNetCore.Http;
using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal
{
    public class TestMiddleware
    {
        private RequestDelegate nextDelegate;

        public TestMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext context, PortalDbContext dataContext)
        {
            if (context.Request.Path == "/test")
            {
                await context.Response.WriteAsync(
                    $"Toplam {dataContext.News.Count()} adet haber var.\n");
                await context.Response.WriteAsync(
                    $"Toplam {dataContext.Categories.Count()} adet kategori var.\n");
            }
            else
            {
                await nextDelegate(context);
            }
        }
    }
}
