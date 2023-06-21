// See https://aka.ms/new-console-template for more information
int numero = 0, somaPares=0, somaImpares=0;
do
{
    
    Console.WriteLine("Digite um número: ");
    numero = Int32.Parse(Console.ReadLine());
    if (numero > 0)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é par.");
            somaPares += numero;
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ímpar.");
            somaImpares += numero;
        }
    }
} while (numero > 0);
Console.WriteLine("A soma dos números pares é " + somaPares +
    " a soma dos números ímpares é " + somaImpares);
