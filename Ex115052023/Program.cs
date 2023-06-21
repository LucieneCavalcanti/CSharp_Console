// See https://aka.ms/new-console-template for more information
float valorPeca = 0, quantidadePeca = 0, totalComissao = 0;
string codigoVendedor = "", codigoPeca = "";
Console.Write("Digite o código do vendedor: ");
codigoVendedor = Console.ReadLine();
Console.WriteLine("Digite o código da peça: ");
codigoPeca = Console.ReadLine(); 
Console.WriteLine("Digite o valor da peça: ");
valorPeca = float.Parse(Console.ReadLine());    
Console.WriteLine("Digite a quantidade vendida: ");
quantidadePeca = float.Parse(Console.ReadLine());
totalComissao = valorPeca * quantidadePeca * 0.05f;
Console.WriteLine("O total da comissão é " + totalComissao);
