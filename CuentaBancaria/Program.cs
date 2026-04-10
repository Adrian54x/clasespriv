Console.Write("Ingrese su saldo:");
Cuentas c = new Cuentas();
double x;
if(double.TryParse(Console.ReadLine(), out x))
{
	c.Saldo = x;
}
else
{
    Console.WriteLine("Dato no valido!");
}
class Cuentas
{
	private double saldo;

	public  double Saldo
	{
		get { return saldo; }
		set 
		{ 
			if (value > 0) 
			{
                Console.WriteLine("Saldo realizado");
				saldo = value; 
			} 
			else
			{
                Console.WriteLine("Saldo no aceptado!");
			}
		}
	}

}