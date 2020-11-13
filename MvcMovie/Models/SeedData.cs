﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
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
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2000-12-14"),
                        Genre = "Drama",
                        Rating = "PG",
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQV54lBAfe0covp9IR-AK14dwdE9OGOCjEkhDWPJmYtacWR7j0O",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQV54lBAfe0covp9IR-AK14dwdE9OGOCjEkhDWPJmYtacWR7j0O",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Action",
                        Rating = "PG",
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQV54lBAfe0covp9IR-AK14dwdE9OGOCjEkhDWPJmYtacWR7j0O",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Singles Ward",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQV54lBAfe0covp9IR-AK14dwdE9OGOCjEkhDWPJmYtacWR7j0O",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}