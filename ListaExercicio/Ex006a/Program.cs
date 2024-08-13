//1 - Criar uma variável ou um vetor.
//2 - Criar um laço para percorrer o vetor.
//3 - Gerar um valor aleatório para cada posição.
//4 - Ordenar o vetor Bubble Sort. 

int tamanho = 100;
int [] vetor = new int [tamanho];
Random random = new Random();

for (int i = 0; i < tamanho; i++) //for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(0, 100); //vetor[i] = random.Next(100);
}

Console.WriteLine("");

//Ordenação do vetor com Bubble Sort
for (int i = 0; i < tamanho - 1; i++)
{
    if (vetor[i] > vetor[i+1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i+1];
        vetor[i+1] = aux;    
    }  
}

//Imprimir o vetor com valores com ordenação
for (int i = 0; i < tamanho; i++)
{ 
    Console.WriteLine("O Número é: " + vetor[i]);
}



