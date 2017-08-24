using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using VideosMenuDAL;


namespace VideosMenuBLL.Services
{

    public class VideoService : IVideoService  // This means the actual CustomerService class should have all the implementation from ICustomerService
    {
        IVideoRepository repo;
        public VideoService(IVideoRepository repo)
        {
            this.repo = repo;
        }
        public Video Create(Video vid)
        {
            return repo.Create(vid);
        }



        public Video Delete(int id)
        {
            
            return repo.Delete(id);


        }

        public Video Get(int id)
        {
            return repo.Get(id);
        }


        public List<Video> GetAll()
        {
            return repo.GetAll();
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