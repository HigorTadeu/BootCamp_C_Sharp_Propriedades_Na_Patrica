using BootCamp_C_Sharp_Propriedades_Na_Patrica.Models;

/* Dicionário */

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SE","Sergipe");
estados.Add("BA","Bahia");
estados.Add("SP","São Paulo");

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//Removendo uma chave e seu valor no dictionary
estados.Remove("BA");
//Alterando o valor existente em uma chave
estados["SP"] = "São Paulo - valor alterado";

Console.WriteLine(" - - - - - - - - - - - - - - - -");

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
  Console.WriteLine($"Valor existente: {chave}");
}
else
{
  Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

// Acessando o valor existente com base na chave
Console.WriteLine($"Valor: {estados["SE"]}");
/* Pilha */

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o topo da pilha {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }


/* Fila */

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

/* Tratamento de Exceção */

//new ExemploExcecao().Metodo1();


/*
  Leitura de arquivo
*/

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }    
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado.{ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.Write($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"Chegou até aqui");
// }




// Pessoa p1 = new Pessoa();
// p1.Nome = "Higor";
// p1.Sobrenome = "Tadeu";

// Pessoa p2 = new Pessoa(nome: "Alane", sobrenome: "Patrícia");

// Curso cursoIngles = new Curso();
// cursoIngles.Nome = "Inglês";
// cursoIngles.Alunos = new List<Pessoa>();

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();