int userChoice = GetUserChoice();

do{
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while(userChoice !=3);
 
 static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
 }

 static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 for traingle\nEnter 2 for partial triangle\nEnter 3 to exit");
 }

 static bool IsValidChoice(string userInput)
{
    int ran = new Random().Next(3,9);
    if(userInput == "1")
    {
        for(int i = ran; i>0; i--)
        {
            for(int j = i; j<ran; j++)
            {
                Console.Write("o\t");
            }
            System.Console.WriteLine();
        }
    }

    if(userInput =="2")
    {
        for(int i = ran; i>0; i--)
        {
            for(int j = i; j<ran; j++)
            { 
                    if (j==3 || j==5 || j==9)
                    {
                        Console.Write("\t");
                    }
                Console.Write("o\t");
            }
            System.Console.WriteLine();
        }
    }

    if(userInput == "3")
    {
        System.Console.WriteLine("Invalid");
    }

    if(userInput == "1" || userInput == "2" || userInput == "3"){
        return true;
    }
    else return false;
}


static void FullTraingle(){
    System.Console.WriteLine("");
    PauseAction();
}

static void PartialTriangle(){
    System.Console.WriteLine("");
    PauseAction();
}

static void Exit(){
    System.Console.WriteLine("");
    PauseAction();
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
        FullTraingle();
    }
    else if(menuChoice==2){
        PartialTriangle();
    }
    else if (menuChoice==3){
        Exit();
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
