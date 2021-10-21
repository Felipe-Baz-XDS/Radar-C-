using System;

namespace radar
{
    class Program
    {
        public static void Radar()
        {
            Console.WriteLine("Qual a velocidade do veiculo:\n");
            int velocidade = int.Parse(Console.ReadLine());

            if(velocidade > 80)
            {
                int valor = ((velocidade - 80)*5); 

                string msg = String.Format("Você foi multado em R{0,2:C}", valor);
                Console.WriteLine(msg);
            }
        }

        static void Main(string[] args)
        {
            Radar();
        }
    }
}
