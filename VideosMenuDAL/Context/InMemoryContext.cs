using System;

using Microsoft.EntityFrameworkCore;
using VideosMenuDAL.Entities;

namespace VideosMenuDAL.Context
{
    public class InMemoryContext : DbContext // DbContext is from EFCore = overall managing database. DbContext is superClass.
    {
        private static DbContextOptions<InMemoryContext> option = new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("TheDB").Options;

        //Options That we want in Memory
        public InMemoryContext() : base (option)
        {
            
        }

        // remember this is from entityFrameWork
        public DbSet<Video> Videos { get; set; }
        
    }
}
