Console.Clear();
int[] array_1 = new int[5];


for(int i = 0; i < array_1.Length; i++)
{
    Console.WriteLine($"[{i+1}] - Insira um número: ");
    array_1[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n");
}

int[] array_2 = new int[array_1.Length];

for(int i = 0; i < array_2.Length; i++)
    array_2[i] = array_1[i];

Console.WriteLine("[THE REPLICATOR OF D'TO]\n");
Console.WriteLine("Array 1:\tArray 2:");

for(int i = 0; i < array_1.Length; i++)
{
    Console.WriteLine(array_1[i] + "\t\t" + array_2[i]);
}
