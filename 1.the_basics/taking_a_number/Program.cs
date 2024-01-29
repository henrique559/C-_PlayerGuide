// int AskForNumber(string text)
// {
//     int num = 0;
    
//     Console.WriteLine(text);
//     num = Convert.ToInt32(Console.ReadLine());

//     return num;
// }

// int AskForNumberInRange(string text, int min, int max)
// {
//     int num = 0;

//     do
//     {
//         Console.WriteLine(text);
//         num = Convert.ToInt32(Console.ReadLine());
            
//         if(num >= min && num <= max)
//             return num;
//     }
//     while(true);
// }

// // int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
// // Console.WriteLine(result);

// int result = AskForNumberInRange("What is the airspeed velocity of an unladen swallow?", 0, 10);
// Console.WriteLine(result);

// // Funções com um linha, em vez de usar o '{}', pode fazer uma expressão retornando o valor com um '=>'
// //ex:
// // int returnDouble (int x) => x * 2;
int Factorial(int number) => number <= 1 ? 1 : number * Factorial(number - 1);


Console.WriteLine(Factorial(5));