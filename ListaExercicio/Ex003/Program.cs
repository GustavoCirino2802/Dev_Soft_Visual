using System;
class Program
{

    static void Main(){

        Console.WriteLine("Digite um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2){

            Console.WriteLine($"O número 1 ({num1}) é maior que o numéro 2 ({num2}).");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"O Número 1 ({num1}) é menor que o número 2 ({num2}).");
        }
        else
        {
            Console.WriteLine($"O Número 1 ({num1}) é igual ao número 2 ({num2}).");
        }

    
}
}