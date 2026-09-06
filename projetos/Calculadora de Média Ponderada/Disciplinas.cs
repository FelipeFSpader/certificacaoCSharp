using System;
namespace CalculadoraPonderada;

public class Disciplina
{

    public string NomeDisciplina { get; set; }
    public double Nota { get; set; }
    public int Horas { get; set; }
    public Disciplina(string disciplinaVar, double notaVar, int horasVar)
    {
       NomeDisciplina = disciplinaVar;
       Nota = notaVar;
       Horas = horasVar; 
    }

    public double CalcularNotaTotal()
    {
        double notaTotal = Nota * Horas;
        return notaTotal;
    }
}