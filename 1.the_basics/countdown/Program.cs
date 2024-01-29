void RecursiveCountdown(int num)
{

    if(num <= 1)
    {
        Console.WriteLine(num);
        return;
    }
    
    else
        Console.WriteLine(num);
        RecursiveCountdown(num - 1);

}

RecursiveCountdown(10);