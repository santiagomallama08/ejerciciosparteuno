namespace ejercicio4
{
    public class clase
    {
        public static void Main ()
        {
            int contador;
            int limite;
            int sumatoria;
            sumatoria = 0;
            contador = 1;
            limite = 10;
            for (contador = 1; contador <= limite; contador++) ;
            sumatoria= sumatoria + limite;
            Console.WriteLine($"el resultado de la sumatoria es {sumatoria}");
        }
    }
}