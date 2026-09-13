//PRIMEIROS COMANDOS 

//comando para escrever no terminal 
Console.WriteLine("Hello, World!");

//duas barras são comentários 

//Diferenca de Console.Write para Console.WriteLine
//Console.WriteLine adiciona avanço de linhas 
//Console.Write não adicona nada

Console.Write("Viva ");
Console.WriteLine("minhas primeiras linhas de código...");


//ARMAZENAS E RECUPERAR DADOS USANDO VALORES LITERAIS E VARIAVEIS 

//existem diferentes tipos de dados

//caracteres char usam aspas simples
//char é apenas 1 item - um caracter literal 
Console.WriteLine('b');

//inteiros int são numércos e não usam aspas 
Console.WriteLine(123);

//float, double e decimal são numéricos também
//são mais precisos que int

//float  
Console.WriteLine(0.25F);

//double  
Console.WriteLine(2.625);

//decimal
Console.WriteLine(12.39816m);

//boolianos bool 
Console.WriteLine(true);
Console.WriteLine(false);

//No geral
//string para palavras, frases ou quaisquer dados alfanuméricos para apresentação, não para cálculo
//char para um único caractere alfanumérico
//int para um número inteiro
//decimal para um número com um componente fracionário
//bool para um true/false valor

//Declarando Variáveis 
string meuNome;
char letraUnica;
int numeroInteiro;
decimal numeroDecimal;
bool verdadeiroFalso;

//atribui valores
meuNome = "Luís";
letraUnica = 'l';
numeroInteiro = 19;
numeroDecimal = 1.3m;
verdadeiroFalso = true;

//Apresenta ou recupera valores
Console.WriteLine(meuNome+letraUnica+numeroInteiro+numeroDecimal+verdadeiroFalso);

//variavel de tipo implicito 
//ela se define a partir do valor que recebe 

var mensagem = "Isso é uma string";
var issoNumero = 20;

//Isso seria impossível 
//var mensagem = "Hello World!";
// mensagem = 10.703m;
Console.WriteLine(mensagem + issoNumero);

//FORMATAÇÃO DE CADEIA DE CARACTERES BÁSICA

// \n faz quebra de linha 
Console.WriteLine("Hello\nWorld!");
// \t faz tabulação, igual apertar tab
Console.WriteLine("Hello\tWorld!");

// \" deixa escrever aspas dentro do texto de forma segura
Console.WriteLine("Hello \"World\"!");

// \\ permite usar contrabarra de forma segura dentro do texto 
Console.WriteLine("c:\\source\\repos");

//verbatim ativa colocando @""
//Faz o compilador interpretar o texto exatamente da forma como digitado 
Console.WriteLine(@"    c:\usuário\source\essa_pasta    
        mais texto");

//Concatenação
//O operador de concatenação de cadeia de caracteres é +
Console.WriteLine("Meu nome é "+meuNome+" e tenho "+numeroInteiro+" anos de idade");
//ou 
string apresenta = "oi, me chamo " + meuNome;
Console.WriteLine(apresenta);

//Interpolação
//uso do cifrão $" e {chaves}
string apresentadois = ($"Meu nome é {meuNome}, tenho {numeroInteiro} anos de idade");
Console.WriteLine(apresentadois);

//OPERAÇÕES BÁSICAS

int nUm = 5;
int nDois = 10;
Console.WriteLine(nUm + nDois);
Console.WriteLine(nDois + 5);

//Sempre usar parenteses quando quiser fazer um calculo dentro de strings 
//Aqui vem certo  
Console.WriteLine(meuNome + " andou " + (nDois + 7) + " ruas.");
//aqui errado 
Console.WriteLine(meuNome + " andou " + nDois + 7 + " ruas.");

// + é o operador de adição
// - é o operador de subtração
// * é o operador de multiplicação
// / é o operador de divisão

Console.WriteLine("Soma: "+ (nUm + nDois));
Console.WriteLine("Subtração: "+ (nUm - nDois));
Console.WriteLine("Multiplicação: "+ (nUm * nDois));
Console.WriteLine("Divisão: "+ (nDois / nUm));

//Incrementar e decrementar valores
//O ++ incrementa o valor da variável em 1
nUm++; //nUm era 5, agora vira 6.

//Operadores de atribuição +=, -=, , *=, ++ e --

//local do operador 

//nDois é igaual a 10
nDois++;                                                //aqui passa a ser 11 
Console.WriteLine("Apresenta: " + nDois);               //aqui deve ainda ser 11
Console.WriteLine($"Incremento tardio: {nDois++}");     //aqui ainda é 11, ele exibiu antes de receber o valor 
Console.WriteLine("Pós incremento tardio: " + nDois);   //aqui dever ser 12, recebeu incremento na linha de cima 
Console.WriteLine("Fourth: " + (++nDois));              //aqui deve ser 13

//Fahrenheit para Celsius 
double Fahrenheit = 94;
double celcius = (Fahrenheit - 32) * (5/9);
Console.WriteLine($"A temperatura {Fahrenheit:F1}ºF é equivalente a {celcius}ºC");