using System;
using System.Dynamic;

namespace BlazorCRUB.Model
{
    public class Film
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
