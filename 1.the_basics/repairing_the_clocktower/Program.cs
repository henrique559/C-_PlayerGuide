Console.Write("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());

string teste = number % 2 == 0 ? "Tick" : "Tock";
Console.WriteLine(teste);

// var teste = (expressão) ? (se verdadeiro, faça isso) : (se não, faça isso);