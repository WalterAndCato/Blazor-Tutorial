using System.Collections.Generic;
using BlazorServerApp2.Shared.Entities;

namespace BlazorServerApp2.Shared.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}