namespace HolaMundo;

public class Helper
{
    public static void ImprimirTítulo(string titulo)
    {
        Console.WriteLine(new string('-', 60));
        Console.WriteLine(titulo.ToUpper());
        Console.WriteLine(new string('-', 60));
    }
}
