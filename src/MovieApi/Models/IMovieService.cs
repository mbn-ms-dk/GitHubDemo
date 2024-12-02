namespace MovieApi.Models;

/// <summary>
/// Defines the contract for a service that provides operations related to movies.
/// </summary>
public interface IMovieService
{
    Task<IEnumerable<MovieDTO>> ReadAll();
}