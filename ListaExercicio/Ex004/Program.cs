using System;

class Program
{
    static void Main(){
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 13)
        {
            Console.WriteLine($"O {nome} tem {idade} anos e é criança");
        }

        else if (idade > 13 && idade < 18)
        {
            Console.WriteLine($"O {nome} tem {idade} anos e é adolescente");
        }

        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine($"O {nome} tem {idade} anos e é Adulto");
        }

        else 
        {
            Console.WriteLine($"O {nome} tem {idade} anos e é Idoso");
        }


}
}
