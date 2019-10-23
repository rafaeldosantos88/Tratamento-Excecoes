using System;

namespace Course140
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());

            //int result = n1 / n2;
            //Console.WriteLine( result);
            //•No caso se a gente colocar como exemplo "10 dividido por 0" o programa vai travar.
            //1→Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.Exceção não tratada:Tentativa de dividir por zero
            //2→at Course140.Program.Main(String[] args) in C:\Temp\Course140\Program.cs:line 12.Aqui vai mostrar qual programa deu erro e a linha que deu o erro.

            Console.WriteLine("________________________________________________________________________________________");

            //Tratando exceções com blocos

            try
            {                                           //Agora tudo esta dentro do bloco try,No caso vou tentar execultar esse comando que esta aqui dentro.
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException )                   //Vou expecificar o tipo de exceção Exception que é o tipo mais genérico de execeção.DivideByZeroException é uma sublcasse do Exception.Exception é uma superclasse aonde vai funcionar o Upcasting no caso DivideByzeroException
            {                                     //Eu vou vou capturar essa essa exceção através do bloco Catch(capturar)
                Console.WriteLine("Erro! Não é permitido a divisão por Zero ! " ); 
            }
            catch (FormatException e) //Deu um apelido à essa Exceção
            {
                Console.WriteLine("Erro de Formato.Não é aceito formato 'String':" + e.Message);  //Se eu digitar uma string como por exemplo aaa,meu programa fará um tratamento de erro."Message" No caso vai ser aquela mensagem padrão que deu ao rodar o programa
            }


        }
    }
}
