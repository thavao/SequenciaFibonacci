int maximo;


Console.WriteLine("Até qual posição da sequência Fibonacci deseja ver?");
maximo = int.Parse(Console.ReadLine());

int[] fibonacci = new int[maximo];



for (int i = 0; i < maximo; i++)
{
    if (i <= 1)
    {
        fibonacci[i] = 1;
    }
    else
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
}

Console.WriteLine($"Sequência Fibonacci até o {maximo}º elemento");

for (int i = 0; i < maximo; i++)
{
    Console.Write($"{fibonacci[i]} ");
}

Console.WriteLine();

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();