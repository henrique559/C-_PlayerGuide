Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "The defende of Consolas";

int row, column;

Console.Write("Target Row? ");
row = Convert.ToInt32(Console.ReadLine()); //6

Console.Write("Target Column? ");
column = Convert.ToInt32(Console.ReadLine()); //5

Console.Beep();
Console.WriteLine($"Deploy to:\n({row}, {column-1})\n({row-1}, {column})\n({row}, {column+1})\n({row+1}, {row-1})");