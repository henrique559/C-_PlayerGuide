int provinces, duchies, estates, total = 0;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("How many provinces do you have?");
provinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nHow many duchies do you have?");
duchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nHow many estates do you have?");
estates = Convert.ToInt32(Console.ReadLine());

total += estates + (duchies * 3) + (provinces * 6);

Console.ReadKey(true);
Console.WriteLine($"\nProvinces: {provinces*6}\nDuchies: {duchies*3}\nEstates: {estates}\nTotal: {total}");

/*
    [Biblioteca de matemática]

    Math.PI = Número de 'pi'
    Math.E = Número de 'E'
    Math.Pow = Potênciação, ex: (Math.Pow(2,2) == 4)
    Math.Sqrt = Raiz quadrada, ex: (Math.Sqrt(9) == 3) 

    EX:
    double area = Math.PI * Math.Pow(radius, 2)

    Math.Abs = Valor absoluto de um número, ex: (Math.Abs(-4) == 4)
    Math.Cos/Sin/Tan = Trigonomêtria, ex: (Math.Cos(0);)

    Math.Min = Retorna o menor número de dois números ou de uma Array.
    Math.Max = Retorna o maior número de dois números ou de uma Array.

    MathF = Usa somente Float (São as mesmas funções de cima)
*/