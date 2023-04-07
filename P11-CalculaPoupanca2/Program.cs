using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11");

        double investimento = 1000;

        // rendimento de 0.5% ao mês (0.005)

        //int mes = 1;

        /*while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
            mes++;
        }*/

        for (int mes = 1; mes <= 12; mes++) 
        {
            //mes = int.Parse(Console.ReadLine());
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }
        


        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
