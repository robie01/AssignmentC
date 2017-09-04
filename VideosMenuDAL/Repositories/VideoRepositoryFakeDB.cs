using System;
using System.Collections.Generic;
using System.Linq;
using VideosMenuDAL.Entities;

namespace VideosMenuDAL.Repositories
{
    public class VideoRepositoryFakeDB : IVideoRepository
    {

        private static int Id = 1;
		private static List<Video> Videos = new List<Video>();

        public Video Create(Video vid)
        {
			Video video;
            Videos.Add(video = new Video()
			{

				Id = Id++,
				Title = vid.Title,
				About = vid.About,
				Owner = vid.Owner
			});

			return video;
        }

        public Video Delete(int id)
        {
			var cust = Get(id);
			Videos.Remove(cust);
			return cust;
        }

        public Video Get(int Id)
        {
           return Videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
			return new List<Video>(Videos);
        }
    }
}
