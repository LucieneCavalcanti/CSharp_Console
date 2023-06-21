// See https://aka.ms/new-console-template for more information
float salario = 0, salarioMedio2Filhos=0, somaSalario2Filhos=0, salarioMedio0Filhos = 0, somaSalario0Filhos = 0;
float somaTodosSalarios = 0, mediaTodosSalarios = 0, menorSalario=0;
int numeroFilhos = 0, resposta = 0, contPessoas2Filhos=0, contPessoas0Filhos = 0, contTodasPessoas = 0;
string nome = "", nomePessoaMenorSalario="";

do
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("Qual é o seu salário:");
    salario = float.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade de filhos: ");
    numeroFilhos = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Deseja cadastrar outra pessoa? 1 - Sim, 2 - Não");
    resposta = Int32.Parse(Console.ReadLine());
    if(numeroFilhos == 2)
    {
        somaSalario2Filhos += salario;
        contPessoas2Filhos++;
    }
    if (numeroFilhos == 0)
    {
        somaSalario0Filhos += salario;
        contPessoas0Filhos++;
    }
    somaTodosSalarios += salario;
    contTodasPessoas++;
    if (contTodasPessoas == 1)
    {
        menorSalario = salario;
        nomePessoaMenorSalario = nome;
    }else if(salario < menorSalario)
    {
        menorSalario = salario;
        nomePessoaMenorSalario = nome;
    }
} while(resposta==1);
salarioMedio2Filhos = somaSalario2Filhos / contPessoas2Filhos;
Console.WriteLine("O salário médio das pessoas que possuem 2 filhos: "
    + salarioMedio2Filhos);
salarioMedio0Filhos = somaSalario0Filhos / contPessoas0Filhos;
Console.WriteLine("O salário médio das pessoas que possuem 0 filhos: "
    + salarioMedio0Filhos);
mediaTodosSalarios = somaTodosSalarios / contTodasPessoas;
Console.WriteLine("O salário médio geral é de : "
    + mediaTodosSalarios);
Console.WriteLine("A pessoa que recebe o menor salário é " + nomePessoaMenorSalario +
    " com o salário de " + menorSalario);