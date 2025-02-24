using System;

class CuentaBancaria
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public int NumeroCuenta { get; set; }
    public string Clave { get; set; }
    public double Saldo { get; set; }

    public CuentaBancaria(
        string nombre,
        string correo,
        string telefono,
        int numeroCuenta,
        string clave,
        double saldo
    )
    {
        Nombre = nombre;
        Correo = correo;
        Telefono = telefono;
        NumeroCuenta = numeroCuenta;
        Clave = clave;
        Saldo = saldo;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Correo: {Correo}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine($"No.Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Saldo: {Saldo}\n");
    }
}

class Banco
{
    private CuentaBancaria cuenta1,
        cuenta2,
        cuenta3,
        cuenta4;

    public Banco()
    {
        cuenta1 = new CuentaBancaria(
            "Alejandra Landero",
            "landero@gmail.com",
            "1234567890",
            1001,
            "clave1",
            2000000
        );
        cuenta2 = new CuentaBancaria(
            "Jose Euan",
            "euan@gmail.com",
            "0987654321",
            1002,
            "clave2",
            40000
        );
        cuenta3 = new CuentaBancaria(
            "Besy Landero",
            "Besy@gmail.com",
            "1122334455",
            1003,
            "clave3",
            6042482
        );
        cuenta4 = new CuentaBancaria(
            "Rodrigo Euan",
            "rororo@gmail.com",
            "5566778899",
            1004,
            "clave4",
            4324234.67
        );
    }

    public void MostrarCuentas()
    {
        cuenta1.MostrarInfo();
        cuenta2.MostrarInfo();
        cuenta3.MostrarInfo();
        cuenta4.MostrarInfo();
    }

    public double CalcularSaldoTotal(int cuenta = 1)
    {
        switch (cuenta)
        {
            case 1:
                return cuenta1.Saldo + CalcularSaldoTotal(2);
            case 2:
                return cuenta2.Saldo + CalcularSaldoTotal(3);
            case 3:
                return cuenta3.Saldo + CalcularSaldoTotal(4);
            case 4:
                return cuenta4.Saldo;
            default:
                return 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco();

        Console.WriteLine("Cuentas en el banco:\n");
        banco.MostrarCuentas();

        double saldoTotal = banco.CalcularSaldoTotal();
        Console.WriteLine($"Saldo total en el banco: {saldoTotal}");
    }
}
