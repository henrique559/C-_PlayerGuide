public class Arrow
{
    // se um field é estático, publico e sem 'readonly', irá virar um estado global
    // private e public = limita o acesso da classe
    // readonly = não permite que o 'field' seja modificado ao decorrer do programa
    // static = nao precisa criar um objeto para usar o metodo da classe


    // Instancias == Objetos
    //Static = Permite utilizar metodos de classes sem usar o nome da classe + operador '.', mas se estiver na mesma classe 
    //se estiver fora, é permitido usar sem inicializar um objeto, só utilizando o nome da classe + '.'
    // Propriedades
    
    static void Main(string[] args)
    {
        bool exit = true;
        ArrowType ArrowHead = 0;
        Fletching Fletch = 0;
        double Length = 0, FinalPrice = 0;
        int ShopOption = 0, ArrowOption = 0;

        Arrow NewArrow = new Arrow();
        
        Console.Clear();
        do
        {

            ShopMenu();
            
            Console.Write("Do you want a pre-defined arrow or a custom one?\n1- Pre defined Arrow\t2- Custom Arrow\n > ");
            ShopOption = Convert.ToInt32(Console.ReadLine());
            if(ShopOption == 1)
            {
                Console.Write("\nWhat pre-defined arrow do you want?\n1- The Elite Arrow\n2- The Beginner Arrow\n3- The Marksman Arrow\n > ");
                ArrowOption = Convert.ToInt32(Console.ReadLine());

                switch (ArrowOption)
                {
                    case 1:
                        FinalPrice = CreateEliteArrow();
                        break;

                    case 2:
                        FinalPrice = CreateBeginnerArrow();
                        break;

                    case 3:
                        FinalPrice = CreateMarksmanArrow();
                        break;

                    default:
                        exit = false;
                        break;
                }

                if(FinalPrice != 0)
                {
                    Console.WriteLine($"\nThe total price is {FinalPrice}G ");
                    exit = true;
                }  
            }
            else if(ShopOption == 2)
            {
                
                Console.Write("[Arrowhead Type] - Insert here your option: ");
                NewArrow.GetArrow = (ArrowType) Convert.ToInt32(Console.ReadLine());

                Console.Write("[Fletching Type] - Insert here your option: ");
                NewArrow.GetFletching = (Fletching) Convert.ToInt32(Console.ReadLine());

                Console.Write("[Arrow Length] - Insert here you much CM do you want: ");
                NewArrow.GetLength = Convert.ToDouble(Console.ReadLine());
            
                FinalPrice = GetCost(NewArrow.GetArrow, NewArrow.GetFletching, NewArrow.GetLength);

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
            else
            {
                exit = false;
                Console.Clear();
            }
        }
        while (!exit);
    }
    private ArrowType ArrowType;
    private Fletching Fletching;
    private double ArrowLength;

    public Arrow() { }

    public static void ShopMenu()
    {
    

            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("|----------------- Pre-defined Arrows --------------|");
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("|- 1 The Elite Arrow | Steel A.H | Plast F. | 95cm -|");
            Console.WriteLine("|- 2 The Beg.  Arrow | Wood  A.H | Goose F. | 75cm -|");
            Console.WriteLine("|- 3 The Mark. Arrow | Steel A.H | Goose F. | 65cm -|");
            Console.WriteLine("|---------------------------------------------------|\n");
        
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("|------------------- Custom Arrows -----------------|");
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("|- Arrowhead Type -|- Fletching Type -|- Length CM -|");
            Console.WriteLine("|------------------|------------------|-------------|");
            Console.WriteLine("| 1 Steel:    10G  | 1- Plastic:  10G |-    0.5G   -|");
            Console.WriteLine("| 2 Wood:      3G  | 2- Turkey F: 5G  |-   PER CM  -|");
            Console.WriteLine("| 3 Obisdian:  5G  | 3- Goose F:  3G  |-===========-|");
            Console.WriteLine("|---------------------------------------------------|");

           return;
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
        set => ArrowLength = (value * 0.5);
    }

    public static double CreateEliteArrow() => GetCost(ArrowType.Steel, Fletching.Plastic, 95);

    public static double CreateBeginnerArrow() => GetCost(ArrowType.Wood, Fletching.Goose, 75);

    public static double CreateMarksmanArrow() => GetCost(ArrowType.Steel, Fletching.Goose, 65);

    public static double GetCost(ArrowType arrow, Fletching fletch, double arrowcm)
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

public enum ArrowType 
{
    Steel = 1,
    Wood = 2,
    Obsidian = 3 
}

public enum Fletching 
{ 
    Plastic = 1,
    Turkey = 2, 
    Goose = 3
}
