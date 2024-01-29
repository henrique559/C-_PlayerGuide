Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();

int manticore_life = 10, city_life = 15, round_countdown = 1, manticore_distance = 0, damage = 0, cannon_range;
bool game_over = false, cannon_strike = false;

manticore_distance = prompt_user1();
Console.WriteLine("Player 2, it is your turn.");

while(!game_over)
{
    damage = damage_calculator(round_countdown);

    Console.WriteLine("---------------------------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round_countdown}  City: {city_life}/15  Manticore: {manticore_life}/10");
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    Console.Write("Enter desired cannon range: ");
    cannon_range = Convert.ToInt32(Console.ReadLine());

    cannon_strike = range_calculator(cannon_range, manticore_distance);
    
    if(cannon_strike == true)
        manticore_life -= damage; 
    else
        city_life--; 
    
    if(manticore_life <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved! ");
        game_over = true;
    }
    else if(city_life <= 0)
    {
        Console.WriteLine("The Manticore has destroyed the city of Consolas... Game Over.");
        game_over = true;
    }
    else
        round_countdown++;
}

int prompt_user1()
{
    int num = 0;
    bool enter = false;
    do
    {
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num >= 0 && num <= 100)
            enter = true;
        else
        {
            Console.WriteLine("I mean... you should digit a number between 0 and 100.");
            Console.ReadKey(true); Console.Clear();
        }
    }
    while(!enter);
    Console.Clear();

    return num;
}

int damage_calculator(int x)
{
    if(x % 3 == 0 && x % 5 == 0)
        return 10;
    else if(x % 5 == 0)
        return 3;
    else if(x % 3 == 0)
        return 3;
    else
        return 1;
}

bool range_calculator(int player1, int manticore)
{
    if(player1 > manticore)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        return false;
    }
    else if(player1 < manticore)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        return false;
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        return true;
    }

}