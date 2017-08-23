using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using VideosMenuDAL;


namespace VideosMenuBLL.Services
{

    public class VideoService : IVideoService  // This means the actual CustomerService class should have all the implementation from ICustomerService
    {
        public Video Create(Video vid)
        {
            Video video;
            FakeDB.Videos.Add(video = new Video()
            {

                Id = FakeDB.Id++,
                Title = vid.Title,
                About = vid.About,
                Owner = vid.Owner
            });

            return video;
        }



        public Video Delete(int id)
        {
            //using LINQ(FirstorDefaultMethod) and lambda expression
            var cust = Get(id);
            FakeDB.Videos.Remove(cust);
            return cust;


        }

        public Video Get(int id)
        {
            return FakeDB.Videos.FirstOrDefault(x => x.Id == id);
        }

        /// 
        /// Gets all the customers list from DAL(FakeDB) and save it to a new list(Generic list)
        /// where its easy for user to manipulate the list from its local list(List<Video>)
        /// <returns>The all.</returns>
        /// 
        public List<Video> GetAll()
        {
            return new List<Video>(FakeDB.Videos);
        }


        public Video Update(Video cust)
        {

            var customerFromDb = Get(cust.Id);
            if (customerFromDb == null)
            {
                throw new InvalidOperationException("Video not found");
            }
            customerFromDb.Title = cust.Title;
            customerFromDb.About = cust.About;
            customerFromDb.Owner = cust.Owner;
            return customerFromDb;
        }


    }
}