using System;
using VideosMenuDAL.Repositories;
using VideosMenuDAL.UOW;

namespace VideosMenuDAL
{
    public class DALFacade
    {
        /* public IVideoRepository VideoRepository
         {
             get { return new VideoRepositoryFakeDB();}

         }*/

        public IUnitOfWork UnitOfWork
		{
			get 
            {
                return new UnitOfWorkMem(); 
            }

		}

    }
}
