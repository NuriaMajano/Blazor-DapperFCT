using BlazorCRUB.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUB.Data.Dapper.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private string ConnectionString;
        public FilmRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetFilmDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertFilm(Film film)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Films (Title, Director, ReleaseDate) VALUES (@Title, @Director, @ReleaseDate)";

            var result = await db.ExecuteAsync(sql.ToString(), new { film.Title, film.Director, film.ReleaseDate });

            return result > 0;
        }

        public Task<bool> UpdateFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
