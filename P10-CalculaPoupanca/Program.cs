using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10");

        double investimento = 1000;

        // rendimento de 0.5% ao mês (0.005)

        //investimento += investimento * 0.005;
        
        //Console.WriteLine(investimento);

        int mes = 1;
        while (mes <= 12) 
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
            mes++;
        }



        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
