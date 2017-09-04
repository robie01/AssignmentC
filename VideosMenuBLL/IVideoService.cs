using System;
using System.Collections.Generic;
using VideosMenuBLL.BO;


namespace VideosMenuBLL
{
    

    public interface IVideoService
    {
        //C
         BOVideo Create(BOVideo vid);

        //R
        List<BOVideo> GetAll();
        BOVideo Get(int Id);

        //U
        BOVideo Update(BOVideo  video);

        //D
        BOVideo Delete(int id);
    }

}
