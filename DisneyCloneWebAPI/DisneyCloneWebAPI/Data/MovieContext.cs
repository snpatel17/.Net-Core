using DisneyCloneWebAPI.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisneyCloneWebAPI.Data
{
    public class MovieContext : IdentityDbContext<ApplicationUser>
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }
        public DbSet<MovieModel> Movies { get; set; }

    }

}
