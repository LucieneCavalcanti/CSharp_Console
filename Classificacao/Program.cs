// See https://aka.ms/new-console-template for more information
/*
Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias: 
- Infantil A = 5 a 7 anos
- Infantil B = 8 a 11 anos 
- Juvenil A = 12 a 13 anos 
- Juvenil B = 14 a 17 anos 
- Adultos = Maiores de 18 anos */
int idade = 0;
do
{
    Console.WriteLine("Digite 0 para terminar.");
    Console.WriteLine("Digite a idade do nadador:");
    idade = Int32.Parse(Console.ReadLine());
    if (idade >= 5 && idade <= 7)
        Console.WriteLine("Infantil A");
    if (idade >= 8 && idade <= 11)
        Console.WriteLine("Infantil B");
    if (idade >= 12 && idade <= 13)
        Console.WriteLine("Juvenil A");
    if (idade >= 14 && idade <= 17)
        Console.WriteLine("Juvenil B");
    if (idade >= 18)
        Console.WriteLine("Adultos");
}while(idade>0);