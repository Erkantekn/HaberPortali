using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models.ViewModels
{
    public class LayoutModel<T>
    {
       
        public T PageModel { get; set; }
        public List<Category> Categories { get; set; }
    }
}
