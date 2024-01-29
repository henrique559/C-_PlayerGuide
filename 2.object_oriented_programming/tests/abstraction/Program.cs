Rectangle rectangle = new Rectangle(3, 2);

Console.WriteLine(rectangle.GetArea());


class Rectangle
{
    private float _width; //fields publicos podem ser manipulado fora da classe utilizado em qualquer lugar
    private float _height; 

    // private/public = nivel de acessibilidade

    public float GetArea() => _width * _height; // Metodos que retornam fields são chamado de 'getters'

    public Rectangle(float width, float height) // Metodos que modificam fields são chamado de 'setters'
    {
        _width = width;
        _height = height;
        UpdateArea();
    }
    
    // É muito comum ver classes com fields privadas, que só podem ser manipuladas dentro da propria classe, porém com metodos que possibilida 
    // mostrar/modificar esses valores dos fields.
    // Servem para manter dados importantes ocultos, para evitar erros.

    public void SetWidth(float value)
    {
        _width = value;
    }

    public void SetHeight(float value)
    {
        _height = value;
    }
}


// Para poder enviar fields privadas pro mundo exterior, precisamos fazer isso através de metodos publicos.
//
//
//

