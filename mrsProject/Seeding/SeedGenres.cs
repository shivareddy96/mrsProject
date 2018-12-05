using mrsProject.Models;
using mrsProject.DAL;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace mrsProject.Seeding
{
    public class SeedGenres
    {
        public static void SeedAllGenres(AppDbContext db)
        {

            Int32 intGenresAdded = 0;
            //String GenreName = "Begin"; //helps to keep track of error on repos
            //List<Genre> Genres = new List<Genre>();

            if (db.Genres.Count() == 13)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Language record count is already 21!");
                throw ex;
            }

            try
            {
                List<Genre> Genres = new List<Genre>();

                Genre g1 = new Genre
                {
                    GenreName = "Adventure"
                };
                Genres.Add(g1);

                Genre g2 = new Genre();
                g2.GenreName = "Contemporary Fiction";
                Genres.Add(g2);

                Genre g3 = new Genre();
                g3.GenreName = "Fantasy";
                Genres.Add(g3);

                Genre g4 = new Genre();
                g4.GenreName = "Historical Fiction";
                Genres.Add(g4);

                Genre g5 = new Genre();
                g5.GenreName = "Horror";
                Genres.Add(g5);

                Genre g6 = new Genre();
                g6.GenreName = "Humor";
                Genres.Add(g6);

                Genre g7 = new Genre();
                g7.GenreName = "Mystery";
                Genres.Add(g7);

                Genre g8 = new Genre();
                g8.GenreName = "Poetry";
                Genres.Add(g8);

                Genre g9 = new Genre();
                g9.GenreName = "Romance";
                Genres.Add(g9);

                Genre g10 = new Genre();
                g10.GenreName = "Science Fiction";
                Genres.Add(g10);

                Genre g11 = new Genre();
                g11.GenreName = "Shakespeare";
                Genres.Add(g11);

                Genre g12 = new Genre();
                g12.GenreName = "Suspense";
                Genres.Add(g12);

                Genre g13 = new Genre();
                g13.GenreName = "Thriller";
                Genres.Add(g13);

                Genre g;

                foreach (Genre Genre in Genres)
                {
                    //see if the language already exists in the database
                    g = db.Genres.FirstOrDefault(x => x.GenreName == Genre.GenreName);

                    //language was not found
                    if (g == null)
                    {
                        //Add the language
                        db.Genres.Add(Genre);
                        db.SaveChanges();
                        intGenresAdded += 1;
                    }

                }

                //foreach (Genre Genre in Genres)
                //{
                //    //set name of book to help debug
                //    GenreName = Genre.GenreName;

                //    //see if book exists in database
                //    Genre dbGenre = db.Genres.FirstOrDefault(g => g.GenreName == Genre.GenreName);

                //    if (dbGenre == null) //repository does not exist in database
                //    {
                //        db.Genres.Add(Genre);
                //        db.SaveChanges();
                //        intGenresAdded += 1;
                //    }
                //    else
                //    {
                //        dbGenre.GenreName = Genre.GenreName;
                //        dbGenre.GenreID = Genre.GenreID;
                //        db.Update(dbGenre);
                //        db.SaveChanges();
                //    }



                //}
            }
            catch
            {
                String msg = "Genres added:" + intGenresAdded;
                throw new InvalidOperationException(msg);
            }

        }
    }
}
