using System;

(string test, int lvl, int poiint) tetris;

Console.WriteLine("Insert here your name");
tetris.test = Console.ReadLine();
Console.WriteLine("Insert here your points");
tetris.poiint = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert here your level");
tetris.lvl = Convert.ToInt32(Console.ReadLine());

Score best = new Score(tetris.test, tetris.poiint, tetris.lvl);

if(best.EarnedStar())
    Console.WriteLine("You earned a star!");

// Classe que encapsula dados e metodos para deixar o programa mais organizado
class Score 
{
    public string name; //Inicialização de fields (variaveis de classes)
    public int points;
    public int level;
    
    public Score(string name, int points, int level)  // Um Constructor que recebe váriaveis fora do escopo como parametro para inicializar os 'fields' automaticamente
    {
        this.name = name;
        this.points = points;
        this.level = level;
    }
    // Com dois constructors, qualquer um pode ser utilizado, desde que utilize parametros diferentes.
    public bool EarnedStar() => (points/level) > 10; // Metodo simples para calcular o se os pontos recebem a "estrela"
}
