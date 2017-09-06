using System;
using VideosMenuDAL.Context;
using VideosMenuDAL.Repositories;

namespace VideosMenuDAL.UOW
{

	public class UnitOfWorkMem : IUnitOfWork
    {
        public IVideoRepository VideoRepository { get; internal set; }
        private InMemoryContext context;

        public UnitOfWorkMem()
        {
            context = new InMemoryContext();
            VideoRepository = new VideoRepositoryEFMemory(context);
        }


        public int Complete()
        {
            // the int in this method is the number of Objects written in the underlying database.
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
