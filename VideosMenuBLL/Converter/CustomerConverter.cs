using System;
using VideosMenuBLL.BO;
using VideosMenuDAL.Entities;

namespace VideosMenuBLL.Converter
{
    public class CustomerConverter
    {

        internal BOVideo Convert(Video vid)
		{
			return new BOVideo()
			{
				Id = vid.Id,
				Title = vid.Title,
				About = vid.About,
				Owner = vid.Owner
			};
		}

        internal Video Convert(BOVideo videoo)
		{
			return new Video()
			{
				Id = videoo.Id,
				Title = videoo.Title,
				About = videoo.About,
				Owner = videoo.Owner

			};
		}

	}
}
