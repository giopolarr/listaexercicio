using System;

 public class Alas
{
    static void Main(string[] args)
    {
      
        List<Aluno> alunos = new List<Aluno>();
        string resposta;
        
        while(true) 
        
        {
            Console.WriteLine("Deseja cadastrar um aluno?");
            resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Aluno a = new Aluno();
                Console.WriteLine("digite o nome do aluno");
                a.Nome = Console.ReadLine();

                Console.WriteLine("digite a matricula do aluno");
                a.Matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite o cpf do aluno: ");
                a.Cpf = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do aluno ");
                a.dataNascimento = Convert.ToDateTime(Console.ReadLine());

                alunos.Add(a);

            }       
            else if(resposta == "nao")
            {
                break;
            }
            
        }

        foreach (Aluno a in alunos)
        {
           Console.WriteLine("O nome é " + a.Nome + " a matricula"+ a.Matricula);

       }

        Console.ReadKey();
    }
}


    