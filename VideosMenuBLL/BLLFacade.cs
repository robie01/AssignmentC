using System;
using VideosMenuBLL.Services;
using VideosMenuDAL;

namespace VideosMenuBLL
{
    public class BLLFacade
    {
        public IVideoService VideoService
        {
            get { return new VideoService(new DALFacade()); }
        }
    }
}
