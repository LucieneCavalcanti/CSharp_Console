// See https://aka.ms/new-console-template for more information
/*
 Faça um algoritmo para ler a temperatura média de alguns dias do ano.
Calcular e escrever:
- Temperatura média dos dias digitados
- O número de dias no ano em que a temperatura foi inferior a média anual
- as 2 maiores e as duas menores temperaturas
Não utilize vetores para resolver este algoritmo.
 */
float temperaturaDigitada = 0, maiorTemperatura1 = 0, maiorTemperatura2 = 0,
    menorTemperatura1 = 9999999, menorTemperatura2 = 999999, somaTemperaturas=0, 
    mediaTemperaturas=0;
int contDias = 0, continuar=0, contDiasTemperaturaInferior=0;
do {
    Console.WriteLine("Digite uma temperatura: ");
    temperaturaDigitada=float.Parse(Console.ReadLine());
    contDias++;
    somaTemperaturas += temperaturaDigitada;
    mediaTemperaturas = somaTemperaturas / contDias;
    if (mediaTemperaturas > temperaturaDigitada)
        contDiasTemperaturaInferior++;
    if (menorTemperatura1>temperaturaDigitada)
    {
        menorTemperatura1 = temperaturaDigitada;
    }
    if (menorTemperatura2 > temperaturaDigitada)
    {
        menorTemperatura2= temperaturaDigitada;
    }
    Console.WriteLine("Deseja continuar? Digite 1 - para sim e qualquer caractere para não.");
    continuar = Int32.Parse(Console.ReadLine());
}while (continuar==1);

Console.WriteLine("A média das temperaturas foi: " + mediaTemperaturas);
Console.WriteLine("Ocorreram " + contDiasTemperaturaInferior + " com temperatura abaixo da média.");