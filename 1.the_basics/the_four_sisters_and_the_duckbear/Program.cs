float sister = 4f, chocolate_egg, duckbear, div_result;

Console.WriteLine("Quantos ovos de chocolate vocês conseguiram hoje?");
chocolate_egg = Convert.ToSingle(Console.ReadLine());

duckbear = chocolate_egg % sister;
div_result = Convert.ToInt32(chocolate_egg / sister);

Console.WriteLine($"Para as irmãs: {div_result} para cada.\nPara o Duckbear: {duckbear}.");