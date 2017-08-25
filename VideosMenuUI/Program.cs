using System;
using System.Collections.Generic;
using Entity;
using VideosMenuBLL;
using static System.Console;

namespace VideosMenuUI
{
    class Program
    {
        static BLLFacade bllFacade = new VideosMenuBLL.BLLFacade();

        static void Main(string[] args)
		{


			var cust1 = new Video()
			{

                Title = "awesome video",
                About = "c#",
                Owner = "Robie"

			};
            bllFacade.VideoService.Create(cust1);

            bllFacade.VideoService.Create(new Video()
			{

				Title = "Second video",
				About = "database",
				Owner = "Finnur"

			});

            Console.WriteLine($" Id: {cust1.Id} Title: {cust1.Title} About: {cust1.About} Owner: {cust1.Owner}");



            string[] menuItems = { "List of videos", "Add video", "Edit video", "Delete video", "exit" };


			//show menu
			//wait for selection or 
			// warning and go back to menu

			var selection = showMenu(menuItems);

			while (selection != 5)
			{

				switch (selection)
				{
					case 1:
                        VideosList();
						break;
					case 2:
						AddCustomers();
						break;
					case 3:
						EditCostumers();
						break;
					case 4:
						DeleteCustomers();
						break;
					default:
						break;

				}

				selection = showMenu(menuItems);

			}

			WriteLine("Bye");
			ReadLine();

		}


		/// <summary>
		/// Edits the costumers.
		/// </summary>
        private static Video EditCostumers()
		{
            var video = FindVideoById();
            if (video != null)
			{

				WriteLine("Title:");
                video.Title = ReadLine();
				WriteLine("About:");
                video.About = ReadLine();
				WriteLine("Owner:");
                video.Owner = ReadLine();
			}
			else
			{
				Console.WriteLine("Video not found!");
			}

            return video;
		}


        private static Video FindVideoById()
		{
            int id;
			WriteLine("Insert Video's id:");

            while (!int.TryParse(ReadLine(), out id))
            {
                WriteLine("Please enter a number.");
            }


            foreach (var customer in bllFacade.VideoService.GetAll())
			{
				if (customer.Id == id)
				{
					return customer;
				}
			}
			return null;
		}

		private static void DeleteCustomers()
		{
            var customerFound = FindVideoById();

			if (customerFound != null)
			{
                bllFacade.VideoService.Delete(customerFound.Id);

			}


			// ternary operator (operation, ?, :)
			var response = customerFound == null ? "\nVideo not found!" : "Video deleted.";
			Console.WriteLine(response);

		}

		public static void AddCustomers()
		{
			WriteLine("Title:");
			var title = ReadLine();
			WriteLine("About:");
			var about = ReadLine();
			WriteLine("Owner:");
            var owner = ReadLine();


            bllFacade.VideoService.Create(new Video()
            {

                Title = title,
                About = about,
                Owner = owner
            });

           
        }

		// output of customers list in the same format.
		private static void VideosList()
		{
            foreach (var video in bllFacade.VideoService.GetAll())
			{

                Console.WriteLine($" Id: {video.Id} Title: {video.Title} {video.About} Owner: {video.Owner}");

			}
		}

		private static int showMenu(string[] menuItems)
		{

			WriteLine("\nPlease select what you want to do:" + "\n");
			for (int i = 0; i < menuItems.Length; i++)
			{
				WriteLine($"{(i + 1)} : {menuItems[i]}");
			}

			int selection;

			while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
			{
				WriteLine("Please select number between 1-5");
			}


			WriteLine("selection:" + selection);
			return selection;

		}

	}
}
