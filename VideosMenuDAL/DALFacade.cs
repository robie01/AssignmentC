using System;
using VideosMenuDAL.Repositories;

namespace VideosMenuDAL
{
    public class DALFacade
    {
        public IVideoRepository VideoRepository
        {
			get { return new VideoRepositoryFakeDB();}

        }
    }
}
