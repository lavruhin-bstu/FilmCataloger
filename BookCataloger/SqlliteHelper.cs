using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BookCataloger
{
    internal class SqlliteHelper
    {

        internal static List<Film> GetFilms()
        {

            try
            {
                using (var conection = new SQLiteConnection($@"Data Source={System.Environment.CurrentDirectory}\filmDB;Version=3;"))
                {
                    conection.Open();
                    using (var cmd = new SQLiteCommand(@"SELECT ID,
       Author,
       Name,
       Year,
       Category,
       Status,
       Watched,
       Film_lenght
  FROM films;", conection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            List<Film> films = new List<Film>();
                            while (reader.Read())
                            {
                                films.Add(new Film
                                {
                                    ID = reader.GetInt32(0),
                                    Author = reader.GetString(1),
                                    Name = reader.GetString(2),
                                    Year = reader.GetString(3),
                                    Category = reader.GetString(4),
                                    Status = reader.GetString(5),
                                    Watched = reader.GetString(6),
                                    Film_lenght = reader.GetString(7),

                                });
                            }
                            return films;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }
    }


}
