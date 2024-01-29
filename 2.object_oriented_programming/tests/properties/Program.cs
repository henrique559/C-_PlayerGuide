public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    } // Construtor que recebe parametros para a classe.

    public float Width
    {
        get // retorna o valor de mesmo tipo da propriedade
        {
            return _width;
        }
        set // Modifica a propriedade e tem acesso ao 'value', substitui o field.
        {
            _width = value;  
            //Pode ser utilizado também em uma linha como => (), porém com valores mais complexos para 
            // ser retornado, utiliza as chaves
        }
    }

    public float Height 
    {
        get => _height; //retorna
        set => _height = value; //modifica
    }

    public float GetArea
    {
        get => _width * _height;
    }

}


public class Circle
{
    public float X { get; set; } = 0;
    public float Y { get; set; } = 0;
    public float Radius { get; set; } = 0;
}


class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle { Radius = 3, X = -4 };
    }
}

