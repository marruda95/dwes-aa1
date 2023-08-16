using Books;
using Genres;
using Members;
using Microsoft.VisualBasic;

public class UserService {
InitialConfiguration initialConfiguration = new InitialConfiguration();
CommonService commonService = new CommonService(); 
public bool logged = false;
public int userMenu(string langEnv, List<Member> members){

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

        if (userSelected == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorry, that user doesn't exist.\n ");
        } else {
            Console.Write("......... Password:\n ");
            string password = Console.ReadLine();
            if (userSelected.Password == password){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Welcome back {userSelected.Name}! \n");
                logged = true;
                Console.ResetColor();
                return 0;

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incorrect Password");
                Console.ResetColor(); 
                logged = false;
                return 1;
            }
        }

        commonService.splitLine();
        return 1;
    
     } else if (optionUserMenu == "2"){
        // Sign Up
        addNewMember(members);

        commonService.splitLine();
        logged = true;
        return 0;

     } else if (optionUserMenu == "3"){

        commonService.splitLine();
        return 0;

     } else {

        commonService.incorrectInput(langEnv);
        return 0;

     }

}  

public void addNewMember(List<Member> members){
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

}