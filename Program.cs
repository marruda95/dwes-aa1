using Spectre.Console;
using Books;
using Members; 
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
// Initialized variables

int exit = 0;
bool logged = false; 
var _logger = LoggerFactory.Create(builder => builder.AddNLog()).CreateLogger<Program>();
string langEnv = Environment.GetEnvironmentVariable("languaje");
var config = new InitialConfiguration();
var userService = new UserService();
var commonService = new CommonService();
var bookService = new BookService();
var memberList = new List<Member>();
var members = config.defaultUser(memberList);

var bookList = new List<Book>();
var books = config.defaultBooks(bookList);

_logger.LogInformation("App Started");

AnsiConsole.Write(new FigletText("BOOKIES").Color(ConsoleColor.Blue));

while (exit == 0){
    mainMenu();
}

void mainMenu(){
    // Normal Menu: First View
    if (langEnv == "en" && userService.logged == false){
        Console.Write("Welcome to Bookies!\n"); 
        Console.Write("Please choose and option to continue\n"); 
        Console.Write("......... 1 Book Catalog\n"); 
        Console.Write("......... 2 User Area\n"); 
        Console.Write("......... 3 Search By Author\n"); 
        Console.Write("......... 4 Exit App\n");
    } else if (langEnv != "en" && userService.logged == false) {
        Console.Write("Bienvenido a Bookies!\n"); 
        Console.Write("Por favor, elija una opcion para continuar:\n"); 
        Console.Write("......... 1 Catalogo de Libros\n"); 
        Console.Write("......... 2 Area de Usuario\n"); 
        Console.Write("......... 3 Busqueda por Autor\n"); 
        Console.Write("......... 4 Salir\n");
    } else if (langEnv != "en" && userService.logged == true){
        Console.Write("Welcome to Bookies!\n"); 
        Console.Write("Please choose and option to continue\n"); 
        Console.Write("......... 1 Book Catalog\n"); 
        Console.Write("......... 2 User Area\n"); 
        Console.Write("......... 3 Order Book\n"); 
        Console.Write("......... 4 Search By Author\n"); 
        Console.Write("......... 5 Exit App\n");
    } else if (langEnv == "es" && userService.logged == true) {
        Console.Write("Bienvenido a Bookies!\n"); 
        Console.Write("Por favor, elija una opcion para continuar:\n"); 
        Console.Write("......... 1 Catalogo de Libros\n"); 
        Console.Write("......... 2 Area de Usuario\n"); 
        Console.Write("......... 3 Reservar Libro\n"); 
        Console.Write("......... 4 Busqueda por Autor\n"); 
        Console.Write("......... 5 Salir\n");
    }
    

    string chosenOption = Console.ReadLine();

    if (userService.logged == true){
       if (chosenOption == "1"){
        bookService.showCatalog(books);
        commonService.splitLine();
        } else if (chosenOption == "2") {
            _logger.LogInformation("User Login");
            exit = userService.userMenu(langEnv, members);
        } else if (chosenOption == "3") {
            _logger.LogInformation("User ordered book");
            books = bookService.orderBook(books);
        } else if (chosenOption == "4") {
            _logger.LogInformation("User searched for author");
            bookService.searchByAuthor(books);
        } else if (chosenOption == "5") {
            _logger.LogInformation("App Exited");
            exit = commonService.exitingApp(langEnv);
        } else {
            _logger.LogInformation("Incorrect Input");
            exit = commonService.incorrectInput(langEnv); 
        }
    }

    if (userService.logged == false){
         if (chosenOption == "1"){
        bookService.showCatalog(books);
        commonService.splitLine();
        } else if (chosenOption == "2") {
            _logger.LogInformation("User Login");
            exit = userService.userMenu(langEnv, members);
        } else if (chosenOption == "3") {
            _logger.LogInformation("User searched for author");
            bookService.searchByAuthor(books);
        } else if (chosenOption == "4") {
            _logger.LogInformation("App Exited");
           exit = commonService.exitingApp(langEnv);
         } else {
            _logger.LogInformation("Incorrect Input");
            exit = commonService.incorrectInput(langEnv); 
        } 
    }
}
