

List<Books> books = new List<Books>();
books.Add(new Books{
    Id = "1",
    Author = "Sarah J Maas",
    Price = 21.00, 
    Name = "A Court of Thorns and Roses",
    datePublished = new DateTime(),
    genre = new List<Genres>{
        new Genres{Genres = "Fantasy"},
        new Genres{Subgenre = "Romance"},
        new Genres{Subrengre = "Young Adult"}
    }
});