namespace Genres; 
using Books;

public class Genres
{
    public int Id {get; set;}
    public string Genre {get; set;}
    public string Subgenre {get; set;}
    public List<Books> book {get; set;}
}