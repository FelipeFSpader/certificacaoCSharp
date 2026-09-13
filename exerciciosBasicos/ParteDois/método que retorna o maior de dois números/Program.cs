//localizar e chamar um método que retorna o maior de dois números.
//método de classe math

Console.Write("Diga um número: ");
int nUm = int.Parse(Console.ReadLine());

Console.Write("Diga um segundo número: ");
int nDois = int.Parse(Console.ReadLine());

//               método  (parâmetros)
int maiorValor = Math.Max(nUm, nDois);
Console.WriteLine($"O maior entre os dois números é: {maiorValor}");
