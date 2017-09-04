using System;
using System.Collections.Generic;
using System.Linq;
using VideosMenuBLL.BO;
using VideosMenuBLL.Converter;
using VideosMenuDAL;
using VideosMenuDAL.Entities;

namespace VideosMenuBLL.Services
{

    public class VideoService : IVideoService // This means the actual CustomerService class should have all the implementation from ICustomerService
    {
        CustomerConverter con = new CustomerConverter();

        DALFacade facade;
        public VideoService(DALFacade facade)
        {
            this.facade = facade;
        }

        public BOVideo Create(BOVideo vid)
        {
            using(var uow = facade.UnitOfWork) // using keyword is calling the disposable. Once it exited the curly braces then it will aut. dispose.
            {

                var Video = uow.VideoRepository.Create(con.Convert(vid));
                uow.Complete();
                return con.Convert(Video);
                
            }
           
           
        }



        public BOVideo Delete(int id)
        {
            using (var uow = facade.UnitOfWork)
            {
               
                var Video = uow.VideoRepository.Delete(id);
				uow.Complete();
				return con.Convert(Video);

            }
        }

        public BOVideo Get(int id)
        {
			using (var uow = facade.UnitOfWork)
			{
                return con.Convert(uow.VideoRepository.Get(id));
			

			}
        }


        public List<BOVideo> GetAll()
        {
			using (var uow = facade.UnitOfWork)
			{
               
                /* var newList = new List<BOVideo>();
                foreach (var v in uow.VideoRepository.GetAll())
                {
                    newList.Add(Convert(v));
                }*/


                return uow.VideoRepository.GetAll().Select(v => con.Convert(v)).ToList(); 


			}
        }


        public BOVideo Update(BOVideo cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var customerFromDb = uow.VideoRepository.Get(cust.Id); // ?????
				if (customerFromDb == null)
				{
					throw new InvalidOperationException("Video not found");
				}

				customerFromDb.Title = cust.Title;
				customerFromDb.About = cust.About;
				customerFromDb.Owner = cust.Owner;
                uow.Complete();
				return con.Convert(customerFromDb);
                
            }


        }

     

       
    }
}