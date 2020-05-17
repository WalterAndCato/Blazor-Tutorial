using System.Collections.Generic;
using BlazorServerApp2.Shared.Entities;
using System;

namespace BlazorServerApp2.Shared.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Title = "Krieg der Sterne", ReleaseDate = new DateTime(1977, 7, 4), Poster = "https://m.media-amazon.com/images/M/MV5BNzVlY2MwMjktM2E4OS00Y2Y3LWE3ZjctYzhkZGM3YzA1ZWM2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,643,1000_AL_.jpg"},
                new Movie() {Title = "Das Imperium schlägt zurück", ReleaseDate = new DateTime(1977, 7, 4), Poster = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,641,1000_AL_.jpg"},
                new Movie() {Title = "Rückkehr der Jedi-Ritter", ReleaseDate = new DateTime(1977, 7, 4), Poster = "https://m.media-amazon.com/images/M/MV5BOWZlMjFiYzgtMTUzNC00Y2IzLTk1NTMtZmNhMTczNTk0ODk1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY999_CR0,0,644,999_AL_.jpg"},
            };
        }
    }
}