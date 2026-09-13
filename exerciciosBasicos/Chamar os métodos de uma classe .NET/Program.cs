//Como chamar métodos na Biblioteca de Classes do .NET

//NomeClasse . NomeMétodo () ; 
//Console    . WriteLine  () ;

//CHAMAR DIFERENTES TIPOS DE MÉTODOS NA BIBLIOTECA DE CLASSES

//Classe objeto = operador classe()  Ramdom.Next() é um método  
  Random dado   = new      Random();
int jogar = dado.Next(1, 7);
Console.WriteLine(jogar);

//COM e SEM Estado

//Sem Estado - estáticos 
//Métodos não dependem do estado atual do aplicativo para funcionarem corretamente
//Funcionam sem referenciar ou alterar os valores já armazenados na memória.
//Não dá erro de compilação com linha vermelha sublinhada - geralmente

Console.WriteLine(); //é um exemplo
Math.Sqrt(25);

//Com Estado - de instância 
//Dependentes de valores armazenados na memória por linhas de código anteriores já executadas
//Modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória.
//Precisam de um objeto/instância de classe pra acessar esse estado - senão dá erro de compilação linha veremelha sublinhada

//public double CalcularNotaTotal()             depende das variáveis Nota Horas
//    {
//       double notaTotal = Nota * Horas;
//        return notaTotal;
//    }

//CRIAR UMA INSTÂNCIA DE UMA CLASSE - OBJETO 

//"Fórmula":  Classe objeto = operadornew classe();     ou      Classe obj  = operador();
//            Random dado   = new         Random();     ou      Random dice = new();

//new -> solicita endereço na memória
//       cria o objeto
//       armazena no endereço
//       retona o endereço para que possa ser salvo no objeto

//Valores de retorno e parâmetros de métodos

Random dice = new();

int jogadaUm = dice.Next();
int jogadaDois = dice.Next(101);
int jogadaTres = dice.Next(50, 1001);

Console.WriteLine($"Primeiro lançamento: {jogadaUm} |Segundo lançamento: {jogadaDois} |Terceiro lançamento: {jogadaTres}");

