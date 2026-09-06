//O curso propõe uma atividade onde é necessário calcular e exibir notas de alunos

//instruções:
//Tenho um pequena lista de dois alunos com as notas das cinco tarefas que eles realizaram.
//Cada nota é expressa como um valor inteiro de 0 a 100, em que 100 representa 100% de acerto.
//As pontuações finais são calculadas pela média das cinco notas de tarefas.
//Meu aplicativo precisa executar operações matemáticas básicas para calcular as notas finais para cada aluno.
//Meu aplicativo precisa produzir/exibir o nome e a pontuação final de cada aluno.

//precisa ser exibido da seguitne maneira:
//Student     Grade
//Sophia      94.6  A                            97 - 100    A+
//Nicolas     83.6  B                            93 - 96     A
//Zahirah     83.4  B                            90 - 92     A-
//Jeong       95.4  A                            87 - 89     B+
//                                               83 - 86     B

int avaliacoes = 5;

int luis1 = 93;
int luis2 = 81;
int luis3 = 94;
int luis4 = 82;
int luis5 = 95;

int felipe1 = 83;
int felipe2 = 96;
int felipe3 = 84;
int felipe4 = 97;
int felipe5 = 85;

double mediaLuis = (luis1+luis2+luis3+luis4+luis5)/avaliacoes;
double mediaFelipe = (felipe1+felipe2+felipe3+felipe4+felipe5)/avaliacoes;

Console.WriteLine("_____Notas final dos alunos_____\n");
Console.WriteLine("Aluno\t\tNota");
Console.WriteLine("Luís:\t\t"+ mediaLuis + "\tB+");
Console.WriteLine("Felipe:\t\t"+ mediaFelipe + "\tB+");




