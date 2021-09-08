using System;

namespace basicosNET
{
    class Program
    {
        static void Main(string[] args)
        {

            TestaDivisao(0);

            Console.ReadLine();
        }

        
        public static void TestaDivisao(int divisor)
        {

            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("10 /" + divisor + " = " + resultado);

            }
            catch (Exception e)
            {
                Console.WriteLine("Não é possivel dividir por zero");
                Console.WriteLine();

                Console.WriteLine(e.Message); //Mensagem do Console 
                Console.WriteLine(e.Source ); //Nome do Projeto: 
                Console.WriteLine(e.StackTrace); //Error trace

            }
            
            

        }
        
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("numero zero irmao");
                throw;
            }
        }
        

    }
}
