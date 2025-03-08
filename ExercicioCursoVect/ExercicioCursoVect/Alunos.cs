namespace ExercicioCursoVect;

public class Alunos
{ 
    public string Nome { get; set; }
    public string Email { get; set; }

    public Alunos(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public override string ToString() => $"{Nome} , {Email}";
}