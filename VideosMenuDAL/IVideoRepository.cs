
using System.Collections.Generic;
using VideosMenuDAL.Entities;

namespace VideosMenuDAL
{
    public interface IVideoRepository
    {
		//C
		Video Create(Video vid);

		//R
		List<Video> GetAll();
		Video Get(int Id);


		//D
		Video Delete(int id);
    }
}
