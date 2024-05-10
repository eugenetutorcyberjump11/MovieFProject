public class Movie
{
    public string Title { get; private set; }
    public string Director { get; private set; }
    public int Year { get; private set; }
    public bool IsAvaiblable { get; set; }

    public Movie(string title, string director, int year)
    {
        Title = title;
        Director = director;
        Year = year;
        IsAvaiblable = true;
    }

}