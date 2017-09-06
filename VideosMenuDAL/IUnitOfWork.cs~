using System;
namespace VideosMenuDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IVideoRepository VideoRepository 
        {
            get;
        }

        int Complete();
    }
}
