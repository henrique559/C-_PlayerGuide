do 
{
  (int Option1, Option2, Option3) UserInput;
  
  Arrow.Menu();

  Console.Write("[Arrowhead Type] - Insert here your option: ");
  UserInput.Option1 = Convert.ToInt32(Console.ReadLine());
  
  Console.Write("[Fletching Type] - Insert here your option: ");
  UserInput.Option2 = Convert.ToInt32(Console.ReadLine());

}
while();

//int WhichArrowHead(string n);
//{

//}


class Arrow 
{

  public int ArrowChoice;
  public int FlechChoice;
  public int ArrowLength;

  public Arrow(int _ArrowChoice, int _FlechChoice, int _ArrowLength)
  {
    
  }

  enum ArrowHead
  {
    Steel,
    Wood,
    Obsidian
  }
 
  enum  Fletching
  {
    Plastic,
    Turkey,
    Goose
  }


  int GetCost()
  {
       
  }


  void Menu()
  {
      Console.WriteLine("|-------------------------------------------------|")
      Console.WriteLine("|- Arrowhead Type -|- Fletching Type -|- Lengths -|")
      Console.WriteLine("|------------------|------------------|-----------|")
      Console.WriteLine("| 1- Steel:   10G  | 1- Plastic:  10G |-   0.5G  -|")
      Console.WriteLine("| 2- Wood:     3G  | 2- Turkey F: 10G |-  PER CM -|")
      Console.WriteLine("| 3- Obisdian: 5G  | 3- Goose F:  10G |-=========-|")
      Console.WriteLine("|-------------------------------------------------|")
  }

}


