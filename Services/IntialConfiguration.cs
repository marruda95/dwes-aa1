using Books;
using Genres;
using Members; 
public class InitialConfiguration{
    
public List<Book> defaultBooks(List<Book> books) {
    books.Add(new Book{
        Id = 1,
        Author = "Sarah J Maas",
        Price = 21.00, 
        Name = "A Court of Thorns and Roses",
        datePublished = new DateTime(),
        stock = 1,
        genre = new List<Genre>{
            new Genre{MainGenre = "Fantasy"},
            new Genre{Subgenre = "Romance"},
            new Genre{Subgenre = "Young Adult"}
        }
    });
    books.Add(new Book{
        Id = 2,
        Author = "Sarah J Maas",
        Price = 31.30, 
        Name = "A Court of Mist And Fury",
        datePublished = new DateTime(),
        stock = 5,
        genre = new List<Genre>{
            new Genre{MainGenre = "Fantasy"},
            new Genre{Subgenre = "Romance"},
            new Genre{Subgenre = "Young Adult"}
        }
    });
    books.Add(new Book{
        Id = 3,
        Author = "Sarah J Maas",
        Price = 34.99, 
        Name = "A Court of Wing and Ruin",
        datePublished = new DateTime(),
        stock = 5,
        genre = new List<Genre>{
            new Genre{MainGenre = "Fantasy"},
            new Genre{Subgenre = "Romance"},
            new Genre{Subgenre = "Young Adult"}
        }
    });
    books.Add(new Book{
         Id = 4,
    Author = "Leigh Bardugo",
    Price = 19.50, 
    Name = "The Ninth House",
    datePublished = new DateTime(),
    stock = 5,
    genre = new List<Genre>{
        new Genre{MainGenre = "Mystery"},
        new Genre{Subgenre = "Fantasy"}
    }
    }); 
    return books;  
}

public List<Member> defaultUser(List<Member> members) {
    members.Add(new Member{
        Name = "Maria",
        Email = "mariaemail@gmail.com",
        Password = "1234",
        SignupDate = new DateTime(),
        hasDiscount = true
    });
    return members;
    }
}