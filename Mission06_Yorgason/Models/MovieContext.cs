using Microsoft.EntityFrameworkCore;

namespace Mission06_Yorgason.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) // Constructor
    {
        
    }
    
    public DbSet<MovieInfo> MovieList { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    
    
    
}