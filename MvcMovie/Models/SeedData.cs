using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                // Tutorial movies
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "NR",
                    Price = 3.99M
                },

                // My favorite movies
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-6-24"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Pursuit of Happyness",
                    ReleaseDate = DateTime.Parse("2006-12-15"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 7.49M
                },
                new Movie
                {
                    Title = "Black Panther",
                    ReleaseDate = DateTime.Parse("2018-2-16"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 12.99M
                }
            );
            context.SaveChanges();
        }
    }
}
