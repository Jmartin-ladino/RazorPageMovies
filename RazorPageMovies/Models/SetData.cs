using Microsoft.EntityFrameworkCore;
using RazorPageMovies.Data;


namespace RazorPageMovies.Models
{
    public static class SetData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMoviesContext1(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMoviesContext1>>()))
            {
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPageMovieContext");
                }

                if(context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Slly" ,
                        ReleaseDate = DateTime.Parse("1984-2-12") ,
                        Genre = "Romantic Comedy" ,
                        Price = 9.00M,
                        Rating = "R"
                    },

                     new Movie
                     {
                         Title = "GhostBusters",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "G"
                     },

                     new Movie
                     {
                         Title = "GhostBusters 2",
                         ReleaseDate = DateTime.Parse("1984-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M,
                         Rating = "G"
                     },

                     new Movie
                     {
                    Title = "Rio Bravo",
                         ReleaseDate = DateTime.Parse("1959-4-15"),
                         Genre = "Western",
                         Price = 3.99M,
                         Rating = "NA"
                     }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
