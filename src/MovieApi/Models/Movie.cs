namespace MovieApi.Models;

/// <summary>
/// Represents a movie with details such as title, director, and release year.
/// </summary>
public class Movie
{
    /// <summary>
    /// Gets or sets the unique identifier for the movie.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the movie.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the director of the movie.
    /// </summary>
    public int? DirectorId { get; set; }

    /// <summary>
    /// Gets or sets the director of the movie.
    /// </summary>
    public Person? Director { get; set; }

    /// <summary>
    /// Gets or sets the release year of the movie.
    /// </summary>
    public int Year { get; set; }
}
