public class User
{
    public string Name { get; private set; }
    public List<Movie> WatchedMovies { get; private set; }
    
    public User (string name)
    {
        Name = name;
        WatchedMovies = new List<Movie> ();
    }


    public void WatchMovie(Movie movie)
    {
        if (movie.IsAvaiblable)
        {
            movie.IsAvaiblable = false;
            WatchedMovies.Add(movie);
            Console.WriteLine($"{Name} is watching {movie.Title}");
        }
        else
        {
            Console.WriteLine("This movie is currently unavailable");
        }
    }

    public void ReturnMovie(Movie movie)
    {
        movie.IsAvaiblable = true;
        WatchedMovies.Remove(movie);
        Console.WriteLine($"{Name} has returned {movie.Title}");
    }
}