// Faça um programa que receba a quantidade de faces do dado e sorteie aleatoriamente um valor entre 1 e a quantidade de faces informada, simulando uma rolagem.

int quantidaDeFaces;
int resultado;

Console.WriteLine("--- Simulador de Rolagem de Dado ---\n");

// Solicita a quantidade de faces que tem o dado
Console.Write("Digite a quantidades de faces do dado: ");
quantidaDeFaces = Convert.ToInt32(Console.ReadLine());

// Código para gerar números aleatórios
Random random = new Random();

// Gerador de faces
resultado = random.Next(1, quantidaDeFaces + 1);

// Resultado
Console.WriteLine($"\no resultado da rolagem do dado de {quantidaDeFaces} faces é: {resultado}");