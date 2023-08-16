public class CommonService {

public int incorrectInput(string langEnv) {
    if (langEnv == "en"){
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("------ INCORRECT INPUT ------\n");
        Console.Write("------ Please try again ------");
    } else { 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("------ INPUT INCORRECT  ------\n");
        Console.Write("------ Por favor, intentalo de nuevo ------");
    }
    Console.ResetColor(); 
    return 1;
}

public int exitingApp(string langEnv) {
    if(langEnv == "en") {
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("--------- EXITING APP --------\n");
        Console.Write("------ Come again soon! ------");
    } else {
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.Write("--------- SALIENDO DE APP --------\n");
        Console.Write("------ Nos vemos proximamente! ------");
    }
    
    Console.ResetColor();
    return 1;
}

public void splitLine(){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("----------------------------------------------\n");
    Console.ResetColor();
}

}