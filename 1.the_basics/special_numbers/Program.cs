// int aBigNumber = int.MaxValue;
// short aBigNegativeNumber = short.MinValue;
// double aDoubleInfinityNumber = double.PositiveInfinity;

// Console.WriteLine($"{aBigNumber}\n{aBigNegativeNumber}\n{aDoubleInfinityNumber}");

//int.MaxValue = metodo para calcular o maior número de um tipo inteiro
//int.MinValue = metodo para calcular o menor número de um tipo inteiro 

//double.PositiveInfinity = metodo para mostrar o numero infinito positivo. (funciona somente em pontos flutuantes)
//double.NegativeInfinity = metodo para mostrar o numero infinito negativo. (funciona somente em pontos flutuantes)

//NaN = metodo para mostrar números impossíveis de serem calculados (Not A Number: Divisão por 0)

int a = 5, b = 2;
float result = a / Convert.ToSingle(b);

Console.WriteLine(result);

// Operadores unários: '+' e '-', igualmente matématica, transforma o número em positivo ou negativo
// e respeita o jogo de sinais, menos com menos mais, mais com menos: menos, mais com mais: mais