Producto p = new Producto();
e.Edad = 98;
class Producto
{
    private double edad;

    public double Edad
    {
        get { return edad; }
        set
        {
            if (value > 0 && value <= 100)
            {
                Console.WriteLine("Edad valida");
                edad = value;
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }

}