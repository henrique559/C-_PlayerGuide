using System;

string user_input = "";
bool exit = false;
Chest FIRST_CHEST = Chest.Lock;

Console.Clear();

while(!exit)
    chest_challenge(FIRST_CHEST);


void chest_challenge(Chest x)
{   
    switch(x)
    {
        case (Chest.Open):
            Console.Write("The chest is open. What do you want to do? ");
            user_input = Console.ReadLine();

            if(user_input == "close")
                chest_challenge(Chest.Close);

            break;

        case (Chest.Close):
            Console.Write("The chest is unlocked. What do you want to do? ");
            user_input = Console.ReadLine();

            if(user_input == "lock")
                chest_challenge(Chest.Lock);

            else if(user_input == "open");
                chest_challenge(Chest.Open);
            
            break;

        case (Chest.Lock):
            Console.Write("The chest is locked. What do you want to do? ");
            user_input = Console.ReadLine();

            if(user_input == "unlock")
                chest_challenge(Chest.Unlock);

            break;

        case (Chest.Unlock):
            Console.Write("The chest is unlocked. What do you want to do? ");
            user_input = Console.ReadLine();

            if(user_input == "open")
                chest_challenge(Chest.Open);

            else if(user_input == "lock")
                chest_challenge(Chest.Lock);
            break;

        default:
            Console.WriteLine("Hmm... this doesn't work very well.");
            break;
    }
    return;
}


enum Chest { Open, Close, Lock, Unlock }
