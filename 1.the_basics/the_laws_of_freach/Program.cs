Console.Clear();

int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};
int min_value = int.MaxValue;
int total = 0;

foreach(int array_value in array)
{
    if(array_value < min_value)
        min_value = array_value;

    total += array_value;
}

float media = (float) total / array.Length;

Console.WriteLine($"Valor mínimo da array: {min_value}\nValor médio da array: {media:0.0}");

