using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppMovies.Data;

public class BlazorWebAppMoviesContext(DbContextOptions<BlazorWebAppMoviesContext> options) : DbContext(options)
{
    public DbSet<BlazorWebAppMovies.Models.Movie> Movie { get; set; } = default!;
}