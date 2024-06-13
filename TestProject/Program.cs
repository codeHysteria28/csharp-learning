Random random = new();
int randomNumber = random.Next(1,5);
bool hasWon = true;

do {
    Console.Write("Enter your guess: ");
    int input = Convert.ToInt32(Console.ReadLine());
    if(input == randomNumber){
        Console.WriteLine("You Won !");
        hasWon = false;
    }else {
        Console.WriteLine("Ups, wrong guess :( Try again next time...");
    }
}while(hasWon);