Producto p = new Producto();
p.Precio = 8;
class Producto
{
    private double precio;

    public double Precio
    {
        get { return precio; }
        set
        {
            if (value > 0)
            {
                Console.WriteLine("Precio valido");
                precio = value;
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }

}