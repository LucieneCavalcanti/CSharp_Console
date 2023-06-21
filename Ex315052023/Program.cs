// See https://aka.ms/new-console-template for more information
/*Escreva um programa que leia 3 valores para o lados de um triangulo (A,B, C)
//Verificar se cada lado é menor que a soma dos dois lados
//Se sim, saber se A==B e se B==C sendo verdade, o triângulo é equilátero
//senão verificar se A==B ou se A==C ou B==C, o triângulo é isósceles
//casocontrario o triangulo será escaleno
//Caso os lados fornecidos não representarem um triângulo, mostrar a mensagem */
int ladoA, ladoB, ladoC;
Console.WriteLine("Digite o lado A: ");
ladoA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B: ");
ladoB = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado C: ");
ladoC = int.Parse(Console.ReadLine());
/*
if (ladoA<(ladoB+ladoC))
{
    Console.WriteLine("O lado A é menor que a soma de B+C");

} else if(ladoB<(ladoA+ladoC))
{
    Console.WriteLine("O lado B é menor que a soma de A+C");
} else if (ladoC<(ladoA+ladoB))
{
    Console.WriteLine("O lado C é menor que a soma de A+B");
} else
{
    Console.WriteLine("Os lados não são compatíveis, pois as somas não são maiores.");
}
*/
if (ladoA < (ladoB + ladoC) || ladoB < (ladoA + ladoC) || ladoC < (ladoA + ladoB)) {
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("Triângulo equilátero.");
    } else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("Triângulo isósceles.");
    }
    else
    {
        Console.WriteLine("Triângulo escaleno.");
    }
}
else
{
    Console.WriteLine("Impossível classificar este triângulo.");
}