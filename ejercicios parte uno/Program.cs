﻿
namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doblado;
            Console.WriteLine("por favor ingrese un numero ");
            numero = Convert.ToInt32 (Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine($"el resultado de la operacion es : {resultado}");
        }
    }
}