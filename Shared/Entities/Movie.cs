using System;

namespace BlazorServerApp2.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }

        public string TitleBrief
        {
            get
            {
                if (String.IsNullOrEmpty(Title))
                {
                    return null;
                }

                if (Title.Length > 60) return Title.Substring(0, 60) + "...";
                return Title;
            }
        }
    }

}