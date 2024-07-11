using ExemploExplorando.Models;
using System.Globalization; // para usar o culture.info e deixar as datas, moeda e hora no padrao pt-BR
using Newtonsoft.Json;

//Utilizando métodos de extensão
int numero = 20;
bool par = false;

par = numero.EhPar(); // método de extensão - todos os numeros inteiros terão acesso a esse método
Console.WriteLine($"O número {numero} é " + (par ? "par" : "ímpar"));






//classe genérica
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(10);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);


















// //variável dinâmica
// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");


// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
















// //Tipos anônimos em coleção - o tipo anômino só tem Get, ou seja, é somente leitura, não posso alterá-lo
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// //usa o tipo anônimo quando eu quero somente selecionar o produto e o preco da lista de venda, por exemplo
// //ao invés de todas as propriedades de Venda
// var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
// }


// //Tipos anônimos - O objeto anônimo é somente leitura
// var tipoAnonimo = new { Nome = "Breno", Sobrenome = "Acioli", Altura = 1.85};

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");











// //Tipos nulos
// bool? desejoReceberEmail = null;

// if (desejoReceberEmail.HasValue && desejoReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber email");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber email");
// }









// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}");
//     Console.WriteLine($"Produto: {venda.Produto}");
//     Console.WriteLine($"Preco: {venda.Preco}");
//     Console.WriteLine($"Data: {venda.DataVenda:dd/MM/yyyy HH:mm}");
//     Console.WriteLine($"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
// }















// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licenca de Software", 100.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// //serialização
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// //Escreve um novo arquivo no formato json com o conteúdo do objeto serializado
// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

















// if ternário (alternativa do if)
// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número é " + (ehPar ? "par" : "ímpar"));











// Pessoa p1 = new Pessoa("Breno", "Acioli");

// //Deconstrutor - por ex, se eu construir duas strings, eu estou deconstruindo elas em variáveis separadas
// //syntaxe parecida com a da tupla
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");














// LeituraArquivo arquivo = new();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// } else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }









// //Tuplas
// //Alternativa simples pra quando não quer criar uma classe
// (int, string, string, decimal) tupla = (1, "Breno", "Acioli", 1.85M);
// //Outra syntaxe da tupla
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Breno", "Acioli", 1.85M);
// //Mais outra syntaxe da tupla
// var outroExemploTuplaCreate = Tuple.Create(1, "Breno", "Acioli", 1.85M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Console.WriteLine(estados["MG"]);

















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento no topo {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }














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














// new ExemploExcecao().Metodo1();






















// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/pasta1/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }




















// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// Pessoa p1 = new Pessoa(nome: "Breno", sobrenome: "Acioli");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Nevez Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C4}");


// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));