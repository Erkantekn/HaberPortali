using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class EFPortalRepository : IPortalRepository
    {
        private PortalDbContext context;
        public EFPortalRepository(PortalDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<News> News => context.News;

        public void CreateNews(News n)
        {
            context.Add(n);
            context.SaveChanges();
        }

        public void DeleteNews(News n)
        {
            context.Remove(n);
            context.SaveChanges();
        }

        public void SaveNews(News n)
        {
            var model = context.News.FirstOrDefault(x => x.NewsID == n.NewsID);
            model = n;
            context.SaveChanges();
        }
    }
}
