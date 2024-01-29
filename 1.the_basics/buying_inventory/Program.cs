bool menuIsOpen = true;
int choice = 0;
float price = 0f;
string item_name = "", players_name = "", my_name = "Azeroyska";

do
{
    Console.WriteLine("The following items are available: ");
    Console.WriteLine("1 - Rope\n2 - Torches\n3 - Climbing Equipament\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");

    choice = AskForNumber("What number do you want to see the price of? ");

    Console.Write("What's is your name? ");
    players_name = Console.ReadLine();
    
    switch(choice)
    {
        case 1:
            price = players_name == my_name ? 10 / 2 : 10;
            item_name = "Rope";
            menuIsOpen = false;
            break;
        case 2:
            price = players_name == my_name ? 15 / 2 : 15;
            item_name = "Torch";
            menuIsOpen = false;
            break;
        case 3:
            price = players_name == my_name ? 25 / 2 : 25;
            item_name = "Climbing Equipment";
            menuIsOpen = false;
            break;
        case 4:
            price = players_name == my_name ? (float) 1 / 2 : 1;
            item_name = "Clean Water";
            menuIsOpen = false;
            break;
        case 5:
            price = players_name == my_name ? 20 / 2 : 20;
            item_name = "Machete";
            menuIsOpen = false;
            break;
        case 6:
            price = players_name == my_name ? 200 / 2 : 200;
            item_name = "Canoe";
            menuIsOpen = false;
            break;
        case 7:
            price = players_name == my_name ? (float) 1 / 2 : 1;
            item_name= "Food Supplies";
            menuIsOpen = false;
            break;

        default:
            Console.WriteLine("Invalid number, Try Again.");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
while(menuIsOpen);
Console.WriteLine($"{item_name} costs {price} gold.");

int AskForNumber(string text)
{
    int num = 0;
    
    Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());

    return num;
}