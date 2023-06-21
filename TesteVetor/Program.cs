// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] impares = new int[] { 1, 3, 5, 7, 9,11, 13, 15, 17 };
int[] valores = new int[10];
int somaTodos = 0;
string[] nomes = new string[] { "Tamires", "Nathália", 
    "Sabrina", "Rebeca", "Thaís", "Yan",
    "Jeniffer", "Cauã", "Ricardinho", "Pedrão" };
for (int posicao = 9; posicao >= 0; posicao--)
{
    Console.WriteLine(nomes[posicao]);
}

decimal soma = 0, media = 0;
//receber 10 valores inteiros
for (int i = 0; i < 10; i++)
{
    do
    {
        Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));
        valores[i] = int.Parse(Console.ReadLine());
    } while (valores[i] < 0);
}
int maiorNumero = 0,menorNumero=99999999;
for(int j = 0; j < 10; j++)
{
    Console.WriteLine("O elemento do índice {0} é :{1}", j, valores[j]);
    somaTodos += valores[j];
    if (maiorNumero < valores[j])
        maiorNumero = valores[j];
    if (menorNumero > valores[j])
        menorNumero = valores[j];
}
Console.WriteLine("A soma dos valores é: " + somaTodos);
Console.WriteLine("O maior número digitado foi: " + maiorNumero);
Console.WriteLine("O menor número digitado foi: " + menorNumero);
Console.WriteLine("O diferença entre eles é de : " + (maiorNumero-menorNumero));


/*
 * 
Console.WriteLine("Informe o número de turmas: ");
int num_turmas = int.Parse(Console.ReadLine());
string[][] turmas = new string[num_turmas][];
for (int i = 0; i < num_turmas; i++)
{
    Console.WriteLine("Informe a quantidade de alunos da turma {0}:", i);
    int num_alunos = int.Parse(Console.ReadLine());
    turmas[i] = new string[num_alunos];
    for (int j = 0; j < num_alunos; j++)
    {
        Console.WriteLine("Informe o nome do aluno {0}:", j);
        turmas[i][j] = Console.ReadLine();
    }
}
*/