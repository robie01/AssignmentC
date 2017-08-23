using System;
using System.Collections.Generic;
using Entity;


namespace VideosMenuBLL
{
    

    public interface IVideoService
    {
        //C
         Video Create(Video vid);

        //R
        List<Video> GetAll();
        Video Get(int Id);

        //U
        Video Update(Video  video);

        //D
        Video Delete(int id);
    }

}
