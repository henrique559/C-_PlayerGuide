int user1_guess = 0, user2_guess = 0;
bool acertouGame = false;

do
{
    Console.Clear();
    Console.Write("Olá usuário 1! digite aqui um número de 0 a 100: ");
    user1_guess = Convert.ToInt32(Console.ReadLine());

    if(user1_guess < 0 || user1_guess > 100)
    {
        Console.WriteLine("Número invalido, aperte [ENTER] para tentar novamente");
        Console.ReadKey(true);
    }
}
while(user1_guess < 0 || user1_guess > 100);

Console.Clear();
Console.WriteLine("Usuário 2, adivinhe o número.");

while(!acertouGame)
{
    Console.Write("Digite aqui o seu chute: ");
    user2_guess = Convert.ToInt32(Console.ReadLine());

    if(user2_guess < user1_guess)
        Console.WriteLine($"{user2_guess} está muito baixo.");

    else if(user2_guess > user1_guess)
        Console.WriteLine($"{user2_guess} está muito alto");

    else
    {
        Console.WriteLine($"Você achou o número!");
        acertouGame = true;
    }

}       

