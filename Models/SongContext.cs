using Microsoft.EntityFrameworkCore;  
  
namespace SongLister.Models  
{  
    public class SongContext : DbContext  
    {  
        public SongContext (DbContextOptions<SongContext> options)  
            : base(options)  
        {  
        }  
  
        public DbSet<SongLister.Models.Songs> Song { get; set; }  
    }  
}