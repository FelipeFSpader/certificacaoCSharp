//Declaração de matriz
//tipo [] nome = new tipo [x]
string[] valoresMatriz = new string[3];

valoresMatriz[0] = "A123 - Primeiro";
valoresMatriz[1] = "B456 - Segundo";
valoresMatriz[2] = "C789";

Console.WriteLine($"Primeiro valor: {valoresMatriz[0]}");
Console.WriteLine($"Segundo valor: {valoresMatriz[1]}");

valoresMatriz[0] = "D000";

Console.WriteLine($"Reatribuição do primeiro: {valoresMatriz[0]}");

string[] matrizInicializada = [ "A1", "A2", "A3" ]; //ou string[] matrizInicializada = { "A1", "A2", "A3" }; 

//propriedade .Lenght 

Console.WriteLine($"Número de elementos da matriz: {valoresMatriz.Length}");

//USO DO FOREACH

string[] nomes = { "Luís", "Felipe", "Lucas" };
foreach (string digitado in nomes)
{
    Console.WriteLine(digitado);
}

int[] inventario = {20, 25, 30, 35, 40};
int soma = 0;
int manter = 0; 

foreach (int itens in inventario)
{
    soma += soma + itens; 
    manter++;
    Console.WriteLine($"Caixa {manter} = {itens} items. Total de {soma})");

}

Console.WriteLine ($"Itens no inventário: {soma}");