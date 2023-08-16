using Microsoft.VisualBasic;
using Books;
public class BookService { 
InitialConfiguration initialConfiguration = new InitialConfiguration();
CommonService commonService = new CommonService();

public void showCatalog(List<Book> books) {
     books.ForEach( e => {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine($"Name: {e.Name}");
            Console.ResetColor(); 
            Console.WriteLine($"....... Author: {e.Author}");
            Console.WriteLine($"....... Price: {e.Price}€");
            Console.WriteLine($"....... Published: {e.datePublished}");
          
                if (e.stock > 0 ) {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red; 
                }
                Console.WriteLine($"....... {e.stock} In Stock");
                Console.ResetColor();
            
        } );
}
// public void searchByAuthor(List<Book> books){
//  Console.Write("What author are you searching for?\n");
 
//         string authorLookUp = Console.ReadLine();
        
//         var authorSelected = books.Find( e => e.Author == authorLookUp);
        
//         bool containsResult = authorLookUp.Contains($"{authorSelected.Author}");
        
//         Console.WriteLine($"Searching for: {authorSelected.Author} ....");
        
//         if (authorSelected == null){
//             Console.WriteLine("Oh no! We don't have that author, sorry :(\n");
//         } else {
//             if (containsResult == true){
//                         Console.WriteLine("We have that author! Here are some of their books:\n");
//                         foreach (Book book in books){
//                             if (book.Author == authorSelected.Author) {
//                                 Console.WriteLine($"{book.Name} ........ {book.Price} €");
//                             }
//                         }
//                         commonService.splitLine();
//             } 
//         }
        
       

        
// }

public void searchByAuthor(List<Book> books)
        {
            Console.WriteLine("Introduce the author you're looking for: ");
            string authorName = Console.ReadLine();

            var filteredBooks = new List<Book>();
            books.ForEach(e =>
            {
                if (e.Author.Contains(authorName))
                {
                    filteredBooks.Add(e);
                }
            });

            if(filteredBooks.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Book not found\n");
                Console.ResetColor();
            }
            else
            {
                filteredBooks.ForEach(e =>
                {
                    Console.WriteLine($" - Name: {e.Name}");
                    Console.WriteLine($" - Stock: {e.stock}\n");
                });
            }
        }
    
public List<Book> orderBook(List<Book> books){
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine("Select the book ID you'd like to order: ");
    books.ForEach (e => {
        if (e.stock > 0){
         Console.WriteLine($"....... ID: {e.Id} -- {e.Name}");      
        }
    });
    string chosenOption = Console.ReadLine();
    var chosenBook = books.Find(e => e.Id.ToString() == chosenOption);
    
    if (chosenBook != null){
        Console.WriteLine("Option Selected!");
        chosenBook.stock = chosenBook.stock - 1;
        Console.WriteLine("Order recieved!");
    }

    return books;
    
}

}