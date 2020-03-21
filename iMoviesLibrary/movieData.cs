using iMoviesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iMoviesLibrary
{
    public class movieData : ImovieData
    {
        private readonly imoviesAccess _db;

        public movieData(imoviesAccess db)
        {
            _db = db;
        }

        public Task<List<movieModel>> GetMovie()
        {
            string sql = "select * from dbo.iMovies";

            return _db.LoadData<movieModel, dynamic>(sql, new { });
        }

        public Task InsertMovie(movieModel movie)
        {
            string sql = @"insert into dbo.iMovies (Movie, Year, Length, Summary)
                            values (@Movie, @Year, @Length, @Summary);";

            return _db.SaveData(sql, movie);
        }
    }
}
