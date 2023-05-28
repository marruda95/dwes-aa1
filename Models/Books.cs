namespace Books;
using Genres;
public class Book
{

    public int Id {get; set;}
    public string Name {get; set;}
    public string Author {get; set;}
    public List<Genre> genre {get; set;}
    public double Price {get; set;}
    public DateTime datePublished {get; set;}
    public bool isInStock {get; set;}

}