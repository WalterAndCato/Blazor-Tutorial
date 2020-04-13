using System;
using System.Collections.Generic;
using BlazorServerApp2.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp2.Pages
{
    public partial class Counter
    {
        [Inject] private SingletonService singleton { get; set; }
        [Inject] private TransientService transient { get; set; }
        
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }
    
        private List<Movie> movies;
 
        protected override void OnInitialized()
        {
            base.OnInitialized();
            movies = new List<Movie>
            {
                new Movie() {Title = "<b>Krieg der Sterne Reloaded</b>", ReleaseDate = new DateTime(1977, 7, 4)},
                new Movie() {Title = "<i>Das Imperium schlägt zurück</i>", ReleaseDate = new DateTime(1977, 7, 4)},
                new Movie() {Title = "Rückkehr der Jedi-Ritter", ReleaseDate = new DateTime(1977, 7, 4)},
            };
        }
    }
}