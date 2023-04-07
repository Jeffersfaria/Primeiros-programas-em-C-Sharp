using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13");

       // double fatorRendimento = 1.005;
      //  double investimento = 1000;

        for (int ilinhas = 0; ilinhas <= 9; ilinhas++)

        {
            
            for (int jcolunas = 0; jcolunas <= 9; jcolunas++)
            {
                Console.Write("*");

                if (jcolunas == ilinhas)
                {
                    break;
                }
                
                //investimento *= fatorRendimento;
            }
            // fatorRendimento += 0.001;
            Console.WriteLine();

        }

        //Console.WriteLine("Depois de 5 anos você terá R$" + investimento);

        for (int ilinhas = 0; ilinhas <= 9; ilinhas++)
            
        {

            for (int jcolunas = 0; jcolunas <= ilinhas; jcolunas++)
            {
     
                Console.Write("*");
               //Console.Write("\n O colunas vale: " + jcolunas);
            }
            
            Console.WriteLine();
            //Console.Write("O linhas vale: " + ilinhas);
        }



        for (int linha = 0; linha <= 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if ( coluna >= linha)
                {
                    Console.Write("\n Valor de coluna: " + coluna);
                    break;
                }
                Console.Write(" Valor impresso: " + coluna + 1);
              
            }
            
            Console.WriteLine();
            Console.WriteLine(" Valor de linha: " + linha);
        }

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if (coluna >= linha)
                {
                    Console.Write("\n Valor de coluna: " + coluna);
                    break;
                }
                Console.Write(" Valor impresso: " + coluna + 1);
                Console.Write(coluna);
                
            }

            Console.WriteLine();
            Console.WriteLine(" Valor de linha: " + linha);
        }

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna <= 5; coluna++)
            {
                if (coluna > linha)
                {
                   
                    break;
                }
                Console.Write("\n Valor de coluna: " + coluna);
                Console.Write("\n Valor impresso: ");
                Console.Write(coluna + 1);
                

            }

            Console.WriteLine();
            Console.WriteLine(" Valor de linha: " + linha);

        }

        Console.WriteLine("\n Tecle enter para continuar...");
        Console.ReadLine();
    }
}
