﻿using Spectre.Console;
using Books;
using Genres;
using Members; 

int exit = 0; 

string langEnv = Environment.GetEnvironmentVariable("languaje");

List<Book> books = new List<Book>();
books.Add(new Book{
    Id = 1,
    Author = "Sarah J Maas",
    Price = 21.00, 
    Name = "A Court of Thorns and Roses",
    datePublished = new DateTime(),
    isInStock = true,
    genre = new List<Genre>{
        new Genre{MainGenre = "Fantasy"},
        new Genre{Subgenre = "Romance"},
        new Genre{Subgenre = "Young Adult"}
    }
});
books.Add(new Book{
    Id = 1,
    Author = "Sarah J Maas",
    Price = 31.30, 
    Name = "A Court of Mist And Fury",
    datePublished = new DateTime(),
    isInStock = true,
    genre = new List<Genre>{
        new Genre{MainGenre = "Fantasy"},
        new Genre{Subgenre = "Romance"},
        new Genre{Subgenre = "Young Adult"}
    }
});
books.Add(new Book{
    Id = 1,
    Author = "Sarah J Maas",
    Price = 34.99, 
    Name = "A Court of Wing and Ruin",
    datePublished = new DateTime(),
    isInStock = true,
    genre = new List<Genre>{
        new Genre{MainGenre = "Fantasy"},
        new Genre{Subgenre = "Romance"},
        new Genre{Subgenre = "Young Adult"}
    }
});
books.Add(new Book{
    Id = 2,
    Author = "Leigh Bardugo",
    Price = 19.50, 
    Name = "The Ninth House",
    datePublished = new DateTime(),
    isInStock = false,
    genre = new List<Genre>{
        new Genre{MainGenre = "Mystery"},
        new Genre{Subgenre = "Fantasy"}
    }
});

List<Member> members = new List<Member>();
members.Add(new Member{
    Name = "Maria",
    Email = "mariaemail@gmail.com",
    Password = "1234",
    SignupDate = new DateTime(),
    hasDiscount = true
});

AnsiConsole.Write(new FigletText("BOOKIES").Color(ConsoleColor.Blue));

while (exit == 0){
    mainMenu();
}

void mainMenu(){
    // Normal Menu: First View
    if (langEnv == "en"){
        Console.Write("Welcome to Bookies!\n"); 
        Console.Write("Please choose and option to continue\n"); 
        Console.Write("......... 1 Book Catalog\n"); 
        Console.Write("......... 2 User Area\n"); 
        Console.Write("......... 3 Search By Author\n"); 
        Console.Write("......... 4 Exit App\n");
    } else {
        Console.Write("Bienvenido a Bookies!\n"); 
        Console.Write("Por favor, elija una opcion para continuar:\n"); 
        Console.Write("......... 1 Catalogo de Libros\n"); 
        Console.Write("......... 2 Area de Usuario\n"); 
        Console.Write("......... 3 Busqueda por Autor\n"); 
        Console.Write("......... 4 Salir\n");
    }
    

    string chosenOption = Console.ReadLine();

    if (chosenOption == "1"){
        showCatalog();
        splitLine();
    } else if (chosenOption == "2") {
        exit = userMenu();
    } else if (chosenOption == "3") {
        searchByAuthor();
    } else if (chosenOption == "4") {
        exitingApp();
    } else {
        incorrectInput();
    }
}       

int userMenu(){
    // Secondary Menu: User Area
     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.Write("------- Welcome Back! ------\n");
     Console.Write("------    (or not)    ------\n");
     Console.ResetColor();
     Console.Write("......... 1 Members Login\n"); 
     Console.Write("......... 2 Sign Up\n");
     Console.Write("......... 3 Back to Main Menu\n");

     string optionUserMenu = Console.ReadLine();

    
     if (optionUserMenu == "1"){
        // Login 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please follow the instructions on screen:\n ");
        Console.ResetColor();

        Console.Write("......... Email:\n ");
        string email = Console.ReadLine();
        var userSelected = members.Find( e => e.Email == email);

        if (userSelected.Email == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorry, that user doesn't exist.\n ");
        } else {
            Console.Write("......... Password:\n ");
            string password = Console.ReadLine();
            if (userSelected.Password == password){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Welcome back {userSelected.Name}! \n");
                Console.ResetColor();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incorrect Password");
                Console.ResetColor(); 
                return 1;
            }
        }

        splitLine();
        return 0;
    
     } else if (optionUserMenu == "2"){
        // Sign Up
        addNewMember();

        splitLine();
        return 0;

     } else if (optionUserMenu == "3"){

        splitLine();
        return 1;

     } else {

        incorrectInput();
        return 0;

     }

}  

void showCatalog() {
     books.ForEach( e => {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine($"Name: {e.Name}");
            Console.ResetColor(); 
            Console.WriteLine($"....... Author: {e.Author}");
            Console.WriteLine($"....... Price: {e.Price}€");
            Console.WriteLine($"....... Published: {e.datePublished}");
            if ( e.isInStock == true){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"....... In Stock");
                Console.ResetColor();
            } else if (e.isInStock == false){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"....... Out of Stock");
                Console.ResetColor();
            }
        } );
}

void addNewMember(){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Please fill in the following information:\n ");
    Console.ResetColor();

    Console.Write("......... Email:\n ");
    string email = Console.ReadLine();
    Console.Write("......... Password:\n ");
    string password = Console.ReadLine();
    Console.Write("......... Name: ");
    string name = Console.ReadLine();

    members.Add(new Member{
        Email = $"{email}",
        Password = $"{password}",
        Name = $"{name}",
        hasDiscount = false,
        SignupDate = new DateTime() 
    });
}

void incorrectInput() {
    if (langEnv == "en"){
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("------ INCORRECT INPUT ------\n");
        Console.Write("------ Please try again ------");
    } else { 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("------ INPUT INCORRECT  ------\n");
        Console.Write("------ Por favor, intentalo de nuevo ------");
    }
    exit = 1;
    Console.ResetColor(); 
}

void exitingApp() {
    if(langEnv == "en") {
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("--------- EXITING APP --------\n");
        Console.Write("------ Come again soon! ------");
    } else {
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("--------- SALIENDO DE APP --------\n");
        Console.Write("------ Nos vemos proximamente! ------");
    }
    
    exit = 1; 
    Console.ResetColor();
}

void splitLine(){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("----------------------------------------------\n");
    Console.ResetColor();
}

void searchByAuthor(){
 Console.Write("What author are you searching for?\n"); 
        string authorLookUp = Console.ReadLine();
        var authorSelected = books.Find( e => e.Author == authorLookUp);
        
    
        Console.WriteLine($"Searching for: {authorSelected.Author} ....");
        bool containsResult = authorLookUp.Contains($"{authorSelected.Author}");
        try{
            if (containsResult == true){
                        Console.WriteLine("We have that author! Here are some of their books:\n");
                        foreach (Book book in books){
                            if (book.Author == authorSelected.Author) {
                                Console.WriteLine($"{book.Name} ........ {book.Price} €");
                            }
                        }
                        splitLine();
                    }
        } catch (Exception e){
            Console.WriteLine(e);
            throw;
        }
}