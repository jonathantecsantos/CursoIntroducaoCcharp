using System;

namespace DigitalInovationOneDOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Declaracoes();
            Ponto ponto = new Ponto(1,2);
            Console.WriteLine(ponto.CalcularDistancia());
        }
        static void Declaracoes(){
            int a = 2;
            int b = 3;

            int [] xa = {1,2,3};


            int resultado = a + b;
            Console.WriteLine(resultado);
        }

        
    }
}
