// See https://aka.ms/new-console-template for more information
/*
Um banco concederá um crédito especial aos seus clientes, variável 
com o salário do cliente. 
Faça um algoritmo que leia o salário de um cliente e calcule 
o valor do crédito de acordo com a tabela abaixo. 
Mostre uma mensagem informando o salário e o valor do crédito. 
O programa deverá ser capaz de receber uma quantidade indeterminada
de salários de clientes, terminando quanto o usuário digitar salário
menor que zero.
Ao final, mostrar quantos clientes estão em cada faixa salarial e
a média de todos créditos calculados.

Faixa salarial      Percentual
1 - de 0 a 2000	    nenhum crédito
2 - de 2001 a 4000	20% do valor do saldo médio
3 - de 4001 a 6000	30% do valor do saldo médio
4 - acima de 6001	40% do valor do saldo médio
 */
//entrada de dados
float salario = 0, valorCredito=0, somaCreditos=0;
int contFaixa1=0, contFaixa2=0, contFaixa3=0, contFaixa4=0;

do
{
    Console.WriteLine("Digite o valor do salário:");
    salario= float.Parse(Console.ReadLine());
    if (salario > 0 && salario <= 2000)
    {
        Console.WriteLine("Você não pode pegar um crédito.");
        contFaixa1++;
    }
    if (salario >= 2001 && salario <= 4000) { 
        Console.WriteLine("Faixa 2 - 20% de crédito");
        contFaixa2++;
        valorCredito = salario * 20 / 100;
        Console.WriteLine("#### --- Crédito de: R$ " +  valorCredito + "--- ####");
    }
    if (salario >= 4001 && salario <= 6000) { 
        Console.WriteLine("Faixa 3 - 30% de crédito");
        contFaixa3++;
        valorCredito = salario * 30 / 100;
        Console.WriteLine("#### --- Crédito de: R$ " + valorCredito + "--- ####");
    }
    if (salario >= 6001) { 
        Console.WriteLine("Faixa 4 - 40% de crédito");
        contFaixa4++;
        valorCredito = salario * 40 / 100;
        Console.WriteLine("#### --- Crédito de: R$ " + valorCredito + "--- ####");
    }
    somaCreditos = somaCreditos + valorCredito;

} while (salario>0);
Console.WriteLine("Quantidade de clientes na faixa 1: " + contFaixa1);
Console.WriteLine("Quantidade de clientes na faixa 2: " + contFaixa2);
Console.WriteLine("Quantidade de clientes na faixa 3: " + contFaixa3);
Console.WriteLine("Quantidade de clientes na faixa 4: " + contFaixa4);
float media = somaCreditos / (contFaixa2+contFaixa3+contFaixa4);
Console.WriteLine("A média de todos os créditos é: "+ media.ToString("F2"));
