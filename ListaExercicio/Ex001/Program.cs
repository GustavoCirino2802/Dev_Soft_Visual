using System;
class Program
{
    static void Ex003()
    {
        
        Console.Write("Digite a altura do retângulo: ");     
        double altura = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        
        double area = altura * largura;
      
        Console.WriteLine($"A área do retângulo é: {area}");
    }
}
