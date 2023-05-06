using aulaHerancaDio.Models;

Aluno a1 = new Aluno();

a1.nome = "Guilherme";
a1.idade = 39;
a1.curso = "Análise e desenvolvimento de Sistemas";
a1.nota1 = 10d;
a1.nota2 = 10d;
a1.Apresentar();
a1.ExibirMedia();
System.Console.WriteLine(a1);
System.Console.WriteLine($"A média do aluno {a1.nome} foi: {a1.ExibirMedia()}");
