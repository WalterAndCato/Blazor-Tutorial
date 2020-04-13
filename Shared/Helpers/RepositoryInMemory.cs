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
                new Movie() {Title = "<b>Krieg der Sterne</b>", ReleaseDate = new DateTime(1977, 7, 4)},
                new Movie() {Title = "<i>Das Imperium schlägt zurück</i>", ReleaseDate = new DateTime(1977, 7, 4)},
                new Movie() {Title = "Rückkehr der Jedi-Ritter", ReleaseDate = new DateTime(1977, 7, 4)},
            };
        }
    }
}