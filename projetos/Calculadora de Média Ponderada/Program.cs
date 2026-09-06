using System;
namespace CalculadoraPonderada;

public class Program
{
    static void Main()
    {
        Console.Write("Insira o nome do aluno: ");
        string nomeAluno = Console.ReadLine();

        List<Disciplina> listaDisciplinas = new();

        for (int i = 1; i <= 5; i++)
        {
            
        Console.Write("Insira a disciplinas que o aluno faz: ");
        string nomeVar = Console.ReadLine();
        
        Console.Write("Insira a nota do aluno nesta disciplina: ");
        double notaVar = double.Parse(Console.ReadLine());

        Console.Write("Insira a carga horária desta disciplina: ");
        int horasVar = int.Parse(Console.ReadLine());

        Disciplina disciplinaCompleta = new Disciplina(nomeVar, notaVar, horasVar);
        listaDisciplinas.Add(disciplinaCompleta); // Guarda o objeto pronto dentro da lista

        Console.Clear();

        }
        
        double notasTotais = 0;
        int horasTotais = 0;

        foreach(Disciplina disciplinaCompleta in listaDisciplinas)
        {
           horasTotais = disciplinaCompleta.Horas;

           notasTotais += disciplinaCompleta.CalcularNotaTotal();
        }

        double mediaPonderada = notasTotais / horasTotais;

        Console.WriteLine($"Aluno: {nomeAluno}");
        Console.WriteLine("Disciplina\t\tNotas\t\tHoras\n");

        foreach(Disciplina disciplinaCompleta in listaDisciplinas)
        {
            Console.WriteLine($"{disciplinaCompleta.NomeDisciplina}\t\t\t{disciplinaCompleta.Nota}\t\t{disciplinaCompleta.Horas}");
        }

        Console.WriteLine($"\nMédia Ponderada Final: {mediaPonderada:F2}");
    }
}