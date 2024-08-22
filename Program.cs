using BootCamp_C_Sharp_Propriedades_Na_Patrica.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Higor";
p1.Sobrenome = "Tadeu";

Pessoa p2 = new Pessoa(nome: "Alane", sobrenome: "Patrícia");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();