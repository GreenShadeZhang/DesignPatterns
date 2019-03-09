using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewDemo
{
   public class GetWallpaper
    {
        public async static Task<List<Model.WallPaper>> GetWallpaperMethod()
        {
            using (Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient())
            {
                Uri uri = new Uri("https://www.xworldstudio.cn/api/Applet/GetBing");
             string ret=  await httpClient.GetStringAsync(uri);
                List<Model.WallPaper> res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.WallPaper>>(ret);
                return res;
            }
          
        }
    }
}
