namespace HolaMundo;

public class Helper
{
    public static void ImprimirTítulo(string titulo)
    {
        LíneaHorizontal();
        Console.WriteLine(titulo.ToUpper());
        LíneaHorizontal();
    }

    public static void LíneaHorizontal()
    {
        Console.WriteLine(new string('-', 60));
    }
}
