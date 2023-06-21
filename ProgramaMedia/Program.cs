// See https://aka.ms/new-console-template for more information
//declaração das variáveis
float n1 = 0;
float n2 = 0;
float media = 0;
Console.ForegroundColor = ConsoleColor.Blue;
//entrada de dados
do
{
    Console.WriteLine("Digite a primeira nota:");
    n1 = float.Parse(Console.ReadLine());
} while (n1 > 10 || n1 < 0);
do {
    Console.WriteLine("Digite a segunda nota:");
    n2 = float.Parse(Console.ReadLine());
} while (n2>10 || n2<0);
//processamento - calcular a média
media = (n1 + n2) / 2;
//saída
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("A média é: " + media);
/*
Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias: 

- Infantil A = 5 a 7 anos

- Infantil B = 8 a 11 anos 

- Juvenil A = 12 a 13 anos 

- Juvenil B = 14 a 17 anos 

- Adultos = Maiores de 18 anos



Comandos importantes:

Console.WriteLine("texto") --> Escreve na tela

Console.ReadLine() --> Lê um valor digitado pelo usuário

Int32.Parse("256") --> Converte o valor de texto para inteiro

float.Parse("256") --> Converte o valor de texto para float

do {  

comandos...

} while(condição); --> Faz a execução dos comandos entre chaves e depois testa a condição para 
ver se precisa voltar e executar os comandos novamente.
*/