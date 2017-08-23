using System;


namespace VideosMenuBLL
{
    public class BLLFacade
    {
        public IVideoService GetVideoService()
        {
            return new Services.VideoService();
        }
    }
}
