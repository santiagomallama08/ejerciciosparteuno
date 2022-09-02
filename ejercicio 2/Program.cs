
namespace ejercico2
{
    public class clase
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int suma;
            int media;
            int producto;

            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            num4 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2 + num3 + num4;
            producto = num1 * num2 * num3 * num4;
            media = suma/4 ;
            Console.WriteLine($"la suma de los cuatro numeros es {suma} la multiplicacion de los cuatro numeros es {producto} la media de los cuatro numeros es {media}");
        }
    }
}