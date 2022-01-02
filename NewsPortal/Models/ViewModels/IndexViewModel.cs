using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<News> SliderNews { get; set; }
        public List<News> RandomNews { get; set; }

    }
}
