Empleados e = new Empleados();
e.Saldo = 2000;
class Empleados
{
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (value > 1500)
            {
                Console.WriteLine("Salario valido");
                saldo = value; 
            }
            else
            {
                Console.WriteLine("Salario invalido");
            }
        }
    }

}