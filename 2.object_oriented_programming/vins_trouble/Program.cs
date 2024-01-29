    public class myMain
    {

        static void Main(string[] args)
        {
            Console.Clear();
            bool exit = true;
            double TotalCost = 0;
            ArrowType MyArrow = 0;
            Fletching MyFletch = 0;

            do
            {
                Arrow.ShopMenu();    
                Console.Write("[Arrow Type] - What kind of Arrowhead do you want? ");
                int Arrows = Convert.ToInt32(Console.ReadLine());
                MyArrow = (ArrowType) Arrows;

                Console.Write("[Fletching Type] - What kind of Fletching do you want? ");
                int Fletchs = Convert.ToInt32(Console.ReadLine());
                MyFletch = (Fletching) Fletchs;

                Console.Write("\n[Arrow Length] - How much centimeters do you want in your arrow length? ");
                if(int.TryParse(Console.ReadLine(), out int ArrowLength));

                Arrow UserInput = new Arrow(MyArrow, MyFletch, ArrowLength);
                TotalCost = UserInput.GetCost(MyArrow, MyFletch, ArrowLength);

                if(TotalCost > 0)
                {
                    Console.WriteLine($"[\nPaycheck] - The total is {TotalCost:0.00}G");
                    exit = true;
                } 
            } while (!exit);
        }
    }   
      
public class Arrow
{
    
      private ArrowType ArrowT;
      private Fletching Fletch;
      private int ArrowCM;

      public Arrow(ArrowType ArrowT, Fletching Fletch, int ArrowCM)
      {
          this.ArrowT = ArrowT;
          this.Fletch = Fletch;
          this.ArrowCM = ArrowCM;
      }


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


      public double GetCost(ArrowType x, Fletching y, int z)
      {
          double cost = 0;

          switch(x)
          {
            case ArrowType.Steel:
                cost += 10;
                break;
            case ArrowType.Wood:
                cost += 3;
                break;
            case ArrowType.Obsidian:
                cost += 5;
                break;
          }

          switch(y)
          {
            case Fletching.Plastic:
              cost += 10;
              break;
            case Fletching.Turkey:
              cost += 5;
              break;
            case Fletching.Goose:
              cost += 3;
              break;
          }

          cost += z * 0.5;
          return cost;
      }


}

public enum ArrowType { Steel = 1 , Wood = 2, Obsidian = 3 }
public enum Fletching { Plastic = 1, Turkey = 2, Goose = 3 }
