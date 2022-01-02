using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProgramlamaProjesi.Components
{
    public class DetailNewsViewComponent:ViewComponent
    {
        private  IHttpContextAccessor _httpContextAccessor;
        public DetailNewsViewComponent(PortalDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IViewComponentResult Invoke()
        {
            string username="";
                if(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name)!=null)
            username = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
          
            
            return View(new List<string> (){ username } );
            
        }
    }
}
