namespace Books;
using Genres;
public class Books
{

    public int Id {get; set;}
    public string Author {get; set;}
    public List<Genres> genre {get; set;}
    public decimal Price {get; set;}
    public DateTime datePublished {get; set;}
    public bool isInStock {get; set;}

}