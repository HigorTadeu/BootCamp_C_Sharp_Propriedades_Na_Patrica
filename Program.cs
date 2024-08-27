using BootCamp_C_Sharp_Propriedades_Na_Patrica.Models;
using Newtonsoft.Json;

/* Deserializar */

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda2> listaVenda = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

foreach(Venda2 venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id} - Produto: {venda.Produto} - Preço: {venda.Preco} - Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

/* Serializar */

// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 25.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// string[] arraySerializado = new string[1];
// arraySerializado[0] = serializado;

// //File.WriteAllLines("Arquivos/vendas.json", listaVendas);
// File.WriteAllLines("Arquivos/vendas.json", arraySerializado);

//Console.WriteLine(serializado);


/* Tupla */

//IF Ternário

// int numero = 15;
// bool ehPar = false;

// // Resolvendo com IF Ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é "+ (ehPar ? "par" : "impar"));

// // Resolvendo com IF Normal
// if(numero % 2 == 0)
// {
//   Console.WriteLine($"O número {numero} é par.");
// }
// else
// {
//   Console.WriteLine($"O número {numero} é ímpar.");
// }

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//   Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeDeLinhas);
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não é possível ler o arquivo");
// }

// Usando o conceito de Desconstrutor

// Pessoa p1 = new Pessoa("Higor", "Tadeu");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// (int, string, string, decimal) tupla = (1, "Higor", "Taeu", 1.93M);

// // Outras formas de criar tupla

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Higor", "Taeu", 1.93M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Higor", "Taeu", 1.93M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");



/* Dicionário */

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SE","Sergipe");
// estados.Add("BA","Bahia");
// estados.Add("SP","São Paulo");

// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// //Removendo uma chave e seu valor no dictionary
// estados.Remove("BA");
// //Alterando o valor existente em uma chave
// estados["SP"] = "São Paulo - valor alterado";

// Console.WriteLine(" - - - - - - - - - - - - - - - -");

// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//   Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//   Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Acessando o valor existente com base na chave
//Console.WriteLine($"Valor: {estados["SE"]}");

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