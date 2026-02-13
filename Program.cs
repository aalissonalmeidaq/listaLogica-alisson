// See https://aka.ms/new-console-template for more information

//Nível 1: Variáveis e Operações Básicas
#region 1. Calculadora de média
//// Declaração das variáveis para as notas (double para decimais)

//Console.Write("Digite a primeira nota: ");
//decimal nota1 = Convert.ToDecimal(Console.ReadLine());

//Console.Write("Digite a segunda nota: ");
//decimal nota2 = Convert.ToDecimal(Console.ReadLine());

//Console.Write("Digite a terceira nota: ");
//decimal nota3 = Convert.ToDecimal(Console.ReadLine());

//// Cálculo da média
//decimal media = (nota1 + nota2 + nota3) / 3;


//// Exibição do resultado
//Console.WriteLine($"A média aritmética é: {media:F2}"); // :F2 formata para 2 casas decimais
#endregion

#region 2. Conversor de Idade

Console.Write("Digite sua idade em anos: ");
//// Lemos como int, pois a idade é geralmente um número inteiro
//int idadeAnos = Convert.ToInt32(Console.ReadLine());

//// Conversão para dias (multiplicando por 365)
//// Usamos um long (ou int, dependendo do valor) para armazenar o resultado.
//// O casting (long) é implícito(opcional) aqui se a variável for long
//long idadeDias = (long)idadeAnos * 365;

//Console.WriteLine($"Sua idade em dias (aproximadamente, ignorando bissextos) é: {idadeDias} dias.");


#endregion

#region 3. Troca de Valores
// Valores iniciais
int a = 10;
int b = 25;

Console.WriteLine($"Valores originais: A = {a}, B = {b}");
Console.ReadKey();

// Uso de uma variável temporária para a troca

int temp = a;
a = b;
b = temp;

Console.WriteLine($"Novos valores após a troca: A = {a}, B = {b}");

#endregion

//Nível 2: Estruturas Condicionais
#region 1. Verificador de Maioridade

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

// Condicional simples
if (idade >= 18)
{
    Console.WriteLine("Entrada autorizada.");
}
else
{
    Console.WriteLine("Entrada não autorizada. Menor de idade.");
}
#endregion

#region 2. Classificador de Número
Console.Write("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("O número é Zero.");
}
else if (numero < 0)
{
    Console.WriteLine("O número é Negativo.");
}
else // O número é positivo
{
    // Verifica se é par ou ímpar (usando operador módulo %)
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é Par e positivo.");
    }
    else
    {
        Console.WriteLine("O número é Ímpar e positivo.");
    }
}
#endregion

#region 3. Validação de Login Simples
// Credenciais corretas
string usuarioCorreto = "admin";
string senhaCorreta = "12345";

Console.Write("Usuário: ");
string usuarioDigitado = Console.ReadLine();

Console.Write("Senha: ");
string senhaDigitada = Console.ReadLine();

// Combinação de condições usando o operador lógico E (&&)
if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
{
    Console.WriteLine("Login efetuado com sucesso!");
}
else
{
    Console.WriteLine("Usuário ou senha inválidos.");
}
#endregion

//Nível 3: Estruturas de Repetição (Loops)
#region 1. Contagem Regressiva
// Loop for para contagem regressiva de 10 a 1
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Lançar!");
#endregion

#region 2. Soma de Ímpares (Loop while)
int somaTotalImpares = 0;
int valroDigitado;

Console.WriteLine("Digite números inteiros (digite 0 para parar):");

// Loop while para continuar lendo até que o usuário digite 0
do
{
    Console.Write("Número: ");
    valroDigitado = Convert.ToInt32(Console.ReadLine());

    // Verifica se o número é ímpar (resto da divisão por 2 é diferente de 0)
    if (valroDigitado != 0 && valroDigitado % 2 != 0)
    {
        somaTotalImpares += valroDigitado;
    }
} while (valroDigitado != 0);

Console.WriteLine($"Soma total dos ímpares digitados: {somaTotalImpares}");
#endregion

#region 3. Tabuada Personalizada
Console.Write("Digite o número para a tabuada: ");
int numeroBase = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nTabuada do {numeroBase}:");

// Loop for para multiplicar de 1 a 10
for (int i = 1; i <= 10; i++)
{
    int resultado = numeroBase * i;
    // Exibe no formato "N x M = Resultado"
    Console.WriteLine($"{numeroBase} x {i} = {resultado}");
}
#endregion

//Nível 4: Coleções (Arrays e Listas)
#region 1. Inversão de Array
// Declaração e inicialização do array de strings
string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };

Console.WriteLine("Lista Original:");
// Loop foreach para exibir a lista original
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\nLista Inversa:");
// Loop for para percorrer o array de trás para frente
for (int i = nomes.Length - 1; i >= 0; i--)
{
    Console.WriteLine(nomes[i]);
}

#endregion

#region 2. Busca e Contagem em Lista (foreach)
// Criação e preenchimento da List<string>
List<string> cores = new List<string> { "Vermelho", "Azul", "Verde", "Vermelho", "Amarelo", "Azul", "Vermelho" };

Console.Write("Digite a cor que deseja buscar: ");
string corBuscada = Console.ReadLine();

int contador = 0;

// Loop foreach para percorrer a lista
foreach (string cor in cores)
{
    // Comparação de string, ignorando case (opcional, mas recomendado)
    if (cor.Equals(corBuscada, StringComparison.OrdinalIgnoreCase))
    {
        contador++;
    }
}

Console.WriteLine($"\nA cor '{corBuscada}' aparece {contador} vez(es) na lista.");

#endregion

#region 3. Gerenciador de Tarefas Simples (CRUD Básico em Memória)
// List<string> para armazenar as tarefas em memória
List<string> tarefas = new List<string>();
string opcao;

do
{
    Console.WriteLine("\n--- Gerenciador de Tarefas Simples ---");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Tarefas");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine();

    // Estrutura de controle para o menu (switch ou if/else if)
    switch (opcao)
    {
        case "1":
            Console.Write("Descrição da nova tarefa: ");
            string novaTarefa = Console.ReadLine();
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada!");
            break;

        case "2":
            Console.WriteLine("\n--- Lista de Tarefas ---");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                // Loop for para listar com índice, ou foreach se não precisar do índice
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }
            break;

        case "3":
            Console.WriteLine("Saindo do Gerenciador de Tarefas. Até logo!");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

} while (opcao != "3");
#endregion
