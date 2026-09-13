using System;
using System.Reflection.PortableExecutable;

//Vou usar o método Random.Next() para simular a rolagem de três dados de seis lados cada.
//Vou avaliar os valores para calcular a pontuação. 
//Se a pontuação for superior a um total arbitrário, exibiá uma mensagem de vitória para o usuário.
//Se a pontuação estiver abaixo do corte, você exibirá uma mensagem de derrota para o usuário.

//Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
//Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
//Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo. Caso contrário, você perder

Random dado = new();

int valorUm = dado.Next(1,7);
int valorDois = dado.Next(1,7);
int valorTres = dado.Next(1,7);

int valorTotal = valorUm + valorDois + valorTres;

Console.WriteLine($"O resltado da soma dos dados foi: {valorTotal}\nPrimeiro dado: {valorUm}\nSegundo dado: {valorDois}\nTerceiro dado : {valorTres}");

if ((valorUm == valorDois) || (valorDois == valorTres) || (valorUm == valorTres))
{
    if(valorUm == valorDois && valorDois == valorTres)
    {   
        Console.WriteLine("Resultados triplos. +6 de pontuação");
        valorTotal += 6;
    }
    else
    {
        Console.WriteLine("Resultados duplos. +2 de pontuação");
        valorTotal += 2;
    }
}

if (valorTotal > 16)
{
    Console.WriteLine("Vitória máxima");
}
else if (valorTotal >10)
{
    Console.WriteLine("Vitória grande");
}
else if (valorTotal > 7)
{
    Console.WriteLine("Vitória");
}
else
{
    Console.WriteLine("Derrota...");
}

if (valorTotal > 16)
{
    Console.WriteLine("Parabéns. Prêmio Máximo");
}