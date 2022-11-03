namespace Vehiculos2019_1498;

public class vehiculos 
{
    

    public int vehiculoID {get; set; }
    public char Marca {get; set;} 
    public char Modelo {get; set;}

    private int año1;

    public int Getaño => año1;

    public void Setaño(int value)
    {
        año1 = value;
    }

    public char Color {get; set;}
}


