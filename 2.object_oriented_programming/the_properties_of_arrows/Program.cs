public class myMain
{

    static void Main(string[] args)
    {
        bool exit = true;
        ArrowType ArrowHead = 0;
        Fletching Fletch = 0;
        double Length = 0, FinalPrice = 0;

        Console.Clear();
        do
        {
            Arrow NewArrow = new Arrow();


            NewArrow.ShopMenu();

            Console.Write("[Arrowhead Type] - Insert here your option: ");
            NewArrow.GetArrow = ArrowType(Convert.ToInt32(Console.ReadLine()));

            Console.Write("[Fletching Type] - Insert here your option: ");
            NewArrow.GetFletching = Fletching(Convert.ToInt32(Console.ReadLine()));

            Console.Write("[Arrow Length] - Insert here you much CM do you want: ");
            NewArrow.GetLength = Convert.ToDouble(Console.ReadLine());
            
            FinalPrice = NewArrow.GetCost(NewArrow.GetArrow, NewArrow.GetFletching, NewArrow.GetLength);

            if(FinalPrice >= 0)
            {   
                Console.WriteLine($"The total price is: {FinalPrice}G");
                exit = true;
            }
            else
            {
                Console.WriteLine($"ERRO: Tente novamente.");
                Console.ReadKey(true);

                Console.Clear(); exit = false;
            }
            

        }
        while (!exit);
    }
}   
      
public class Arrow
{
    private ArrowType ArrowType;
    private Fletching Fletching;
    private double ArrowLength;

    private Arrow() { }

      public static void ShopMenu()
      {
           Console.WriteLine("|-------------------------------------------------|");
           Console.WriteLine("|- Arrowhead Type -|- Fletching Type -|- Lengths -|");
           Console.WriteLine("|------------------|------------------|-----------|");
           Console.WriteLine("| 1- Steel:   10G  | 1- Plastic:  10G |-   0.5G  -|");
           Console.WriteLine("| 2- Wood:     3G  | 2- Turkey F: 5G  |-  PER CM -|");
           Console.WriteLine("| 3- Obisdian: 5G  | 3- Goose F:  3G  |-=========-|");
           Console.WriteLine("|-------------------------------------------------|");
      }

    public ArrowType GetArrow
    {
        get => ArrowType;
        set => ArrowType = value;
    }

    public Fletching GetFletching
    {
        get => Fletching;
        set => Fletching = value;
    }
    
    public double GetLength
    {
        get => ArrowLength;
        set => ArrowLength * 0.5;
    }

    public double GetCost(ArrowType arrow, Fletching fletch, float arrowcm)
    {
        double total = 0;

        switch(arrow)
        {
            case ArrowType.Steel:
                total += 10;
                break;

            case ArrowType.Wood:
                total += 3;
                break;

            case ArrowType.Obsidian:
                total += 5;
                break;
        }

        switch(fletch)
        {
            case Fletching.Plastic:
                total += 10;
                break;

            case Fletching.Turkey:
                total += 5;
                break;

            case Fletching.Goose:
                total += 3;
                break;
        }

        total += arrowcm;
        return total;
    
    }

}


public enum ArrowType { Steel = 1 , Wood = 2, Obsidian = 3 }
public enum Fletching { Plastic = 1, Turkey = 2, Goose = 3 }
