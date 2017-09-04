using System;
namespace VideosMenuBLL.BO
{
    public class BOVideo
    {
		
			public int Id
			{
				get;
				set;
			}
			public string Title
			{
				get;
				set;
			}

			public string About
			{
				get;
				set;
			}

			public string Owner
			{
				get;
				set;
			}

        public string AllInformation
            {
            
             get {return ($"{Title} {About} {Owner}"); }
			
            }



    }
}
