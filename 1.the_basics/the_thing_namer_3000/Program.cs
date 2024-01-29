int num1, num2, resultado = 0;
char opt;


Console.WriteLine("Insira aqui um número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira aqui outro número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira aqui o tipo de conta que você deseja fazer: ");
opt = Console.ReadLine()[0];

switch(opt)
{
    case '+':
        resultado = num1 + num2;
        break;
    
    case '-':
        resultado = num1 - num2;
        break;
    
    case '/':
    case '%':
        if(num1 == 0)
        {
            Console.WriteLine("Não foi possível realizar divisão com zero\n");
            return 0;
        }
        else
            resultado = num1 / num2;
            break;
    
    case '*':
    case 'x':
    case 'X':
        resultado = num1 * num2;
        break;
    
    default:
        Console.WriteLine("Tente novamente.\n");
        break;
}

Console.WriteLine($"O Resultado é: {num1} {opt} {num2} = {resultado}");
return 0;

