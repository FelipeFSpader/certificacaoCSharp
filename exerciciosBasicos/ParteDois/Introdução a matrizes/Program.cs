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

//Reportar as IDs de pedido que precisam de uma investigação mais aprofundada

//inicializar a matriz
string[] IDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//paraca cada string dentro de IDs, se começar com B escrever na tela 
foreach (string IDAnalisado in IDs)
{
    if (IDAnalisado.StartsWith("B"))
    {
        Console.WriteLine(IDAnalisado);
    }
}