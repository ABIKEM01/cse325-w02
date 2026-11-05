using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }

    // Added: year filter (shows movies released in this year or newer)
    public SelectList? Years { get; set; }
    public int? MovieYear { get; set; }
}
