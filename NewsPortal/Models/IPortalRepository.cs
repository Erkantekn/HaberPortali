using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public interface IPortalRepository
    {
        IQueryable<News> News { get; }
        void SaveNews(News n);
        void CreateNews(News n);
        void DeleteNews(News n);
    }
}
