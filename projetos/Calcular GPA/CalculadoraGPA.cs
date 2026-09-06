//O curso propõe uma atividade onde é necessário desenvolver uma calculadora GPA 
//Isso significa uma calculadora de média ponderada

//Estou desenvolvendo uma Calculadora de média ponderada do Aluno 
// que ajudará a calcular a média geral de notas dos alunos.

//Os parâmetros para meu aplicativo são:
//Receber o nome do aluno e informações da disciplina.
//Cada disciplina tem um nome, a nota do aluno e o número de horas dessa disciplina.
//Meu aplicativo precisa executar operações matemáticas básicas para calcular a média para o aluno.
//Meu aplicativo precisa produzir/exibir o nome do aluno, as informações de disciplina e a média ponderada.

//Para calcular a média ponderada:
//Multiplicar o valor de nota de um disciplina pelo número de horas para essa disciplina.
//Fazer isso para cada disciplina e adicionar esses resultados juntos.
//Dividir a soma resultante pelo número total de horas.

string nomeEstudante = "Luís Felipe";
string disciplina1 = "Computação em Nuvem";
string disciplina2 = "Calculo I";
string disciplina3 = "Programação Orientada a Objetos";
string disciplina4 = "Estrutra de Dados";
string disciplina5 = "Engenharia de Software";

int horas1 = 40;
int horas2 = 40;
int horas3 = 80;
int horas4 = 80;
int horas5 = 80;

int notaA = 10;
int notaB = 9;

int disciplina1Nota = notaA;
int disciplina2Nota = notaB;
int disciplina3Nota = notaB;
int disciplina4Nota = notaB;
int disciplina5Nota = notaA;

int horasTotais = 0;
int notasTotais = 0;

horasTotais = horas1+horas2+horas3+horas4+horas5;

notasTotais += horas1 * disciplina1Nota;
notasTotais += horas2 * disciplina2Nota;
notasTotais += horas3 * disciplina3Nota;
notasTotais += horas4 * disciplina4Nota;
notasTotais += horas5 * disciplina5Nota;

float mediaPonderada = notasTotais/horasTotais;

int digito = (int) mediaPonderada;
int primeiroDigito = (int) (mediaPonderada * 10 ) % 10;
int segundoDigito = (int) (mediaPonderada * 100 ) % 10;

Console.WriteLine($"Aluno: {nomeEstudante}\n");
Console.WriteLine("Disciplinas\t\t\t\tNotas\t\tHoras\n");

Console.WriteLine($"{disciplina1}\t\t\t{disciplina1Nota}\t\t{horas1}");
Console.WriteLine($"{disciplina2}\t\t\t\t{disciplina2Nota}\t\t{horas2}");
Console.WriteLine($"{disciplina3}\t\t{disciplina3Nota}\t\t{horas3}");
Console.WriteLine($"{disciplina4}\t\t\t{disciplina4Nota}\t\t{horas4}");
Console.WriteLine($"{disciplina5}\t\t\t{disciplina5Nota}\t\t{horas5}");

Console.WriteLine($"\nMédia Ponderada:\t\t{digito}.{primeiroDigito}{segundoDigito}"); //jeito de controlar os decimais