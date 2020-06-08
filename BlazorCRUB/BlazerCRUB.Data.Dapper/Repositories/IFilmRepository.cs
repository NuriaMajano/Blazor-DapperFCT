﻿using System;
using BlazorCRUB.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUB.Data.Dapper.Repositories
{
    interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilms();
        Task<Film> GetFilmDetails(int id);
        Task<bool> InsertFilm(Film film);
        Task<bool> UpdateFilm(Film film);
        Task<bool> DeleteFilm(int id);
    }
}