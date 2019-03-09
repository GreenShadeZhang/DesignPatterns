using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewDemo.Model
{
 
    public class WallPaperModel
    {
        public List<WallPaper> data { get; set; }
    }

    public class WallPaper
    {
        public string Title { get; set; }
        public string Source { get; set; }
    }

}
