using Spectre.Console;
using Books;
using Genres;
using Members; 

List<Books> books = new List<Books>();
books.Add(new Books{
    Id = 1,
    Author = "Sarah J Maas",
    Price = 21.00, 
    Name = "A Court of Thorns and Roses",
    datePublished = new DateTime(),
    isInStock = true,
    genre = new List<Genres>{
        new Genres{Genres = "Fantasy"},
        new Genres{Subgenre = "Romance"},
        new Genres{Subrengre = "Young Adult"}
    }
});
books.Add(new Books{
    Id = 2,
    Author = "Leigh Bardugo",
    Price = 19.00, 
    Name = "The Ninth House",
    datePublished = new DateTime(),
    isInStock = false,
    genre = new List<Genres>{
        new Genres{Genres = "Mystery"},
        new Genres{Subgenre = "Fantasy"}
    }
});

List<Members> members = new List<Members>();
members.Add(new Members{
    Id = 01,
    Name = "Maria",
    Email = "mariaemail@gmail.com",
    Password = "1234",
    SignupDate = new DateTime(),
    hasDiscount = true
});

