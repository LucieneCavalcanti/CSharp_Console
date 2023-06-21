// See https://aka.ms/new-console-template for more information
/*A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
 * coletando dados sobre o salário e número de filhos. 
 * A prefeitura deseja saber:  
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$100,00.
O final da leitura de dados se dará com a entrada de um salário
negativo. (Use o comando ENQUANTO-FAÇA)  */
float salario = 0, somaSalario = 0, mediaSalario=0, maiorSalario=0, somaNumeroFilhos=0, mediaNumeroFilhos=0;
int qtdeFilhos = 0, contPessoas=0, contPessoas100 = 0;
do {
    Console.WriteLine("Digite o salário:");
    salario = float.Parse(Console.ReadLine());
    if (salario > 0)
    {
        contPessoas++;
        somaSalario = somaSalario + salario;
        if (maiorSalario < salario)
            maiorSalario = salario;
        if (salario <= 100)
            contPessoas100++;
        Console.WriteLine("Digite a quantidade de filhos:");
        qtdeFilhos=Int32.Parse(Console.ReadLine()); 
        somaNumeroFilhos = somaNumeroFilhos + qtdeFilhos;
    }
}while (salario>=0);
Console.WriteLine("Quantidade de pessoas pesquisadas:" +  contPessoas);
Console.WriteLine("O maior salário foi: " + maiorSalario);
mediaSalario = somaSalario / contPessoas;
Console.WriteLine("A média dos salário foi: " + mediaSalario);
mediaNumeroFilhos = somaNumeroFilhos / contPessoas;
Console.WriteLine("Média do número de filhos: " + mediaNumeroFilhos);
Console.WriteLine("O percentual de pessoas com salário " +
    "até R$100,00 é: " + (contPessoas100 * 100/ contPessoas));
/* contPessoas -- 100%
contPessoas100 -- x
    x * contPessoas = contPessoas100*100
    x = contPessoas100*100/contPessoas
*/