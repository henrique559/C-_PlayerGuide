float base_tr, height, area;

Console.WriteLine("Insira aqui o tamanho da base do triângulo em cm: ");
base_tr = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Insira aqui o tamanho da altura do triângulo em cm: ");
height = Convert.ToSingle(Console.ReadLine());

area = (base_tr * height) / 2;

Console.WriteLine($"O Resultado da área é: {area}");