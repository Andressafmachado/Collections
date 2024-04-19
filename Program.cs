// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// var numeros = new List<int>() {
//     1,2,3,4,5
// };

// numeros.Add(6);
// Console.WriteLine(numeros[0]);

// foreach (var n in numeros) // for each especifico para colecoes
// {
//     Console.WriteLine(n);
// }

// //HashSet
// HashSet<string> frutas = new HashSet<string>();
// //Adicionando elementos
// frutas.Add("maçã");
// frutas.Add("banana");
// frutas.Add("laranja");

// bool adicionado = frutas.Add("banana");

// Console.WriteLine(adicionado);

// //Verificando se um elemento existe 
// Console.WriteLine($"A banana já está no conjunto: {frutas.Contains("banana")}");
// foreach (var fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }




// ### Lista de Exercícios sobre Loops em C#


// #### Exercício 1: Soma de Números
// - **Descrição:** Escreva um programa que usa um loop `for` para somar os primeiros 100 números naturais (de 1 a 100).


// int acumulado = 0;
// for (int i = 1; i <= 100; i++)
// {
//     var calc = acumulado + i;
//     acumulado = calc;
// }

// Console.WriteLine($"Exercício 1: {acumulado}");
// Console.WriteLine($"-----------------------");


// #### Exercício 2: Números Pares
// - **Descrição:** Utilize um loop `while` para imprimir todos os números pares de 1 a 50.

// var n1 = 0;

// while (n1 <= 50)
// {
//     if(n1 % 2 == 0){
//         // faz divisao e se confere o resto, se o resto for zero eh par
//         Console.WriteLine($"Exercício 2: {n1}");
//     }
//     n1++;
// }

// Console.WriteLine($"-----------------------");

// #### Exercício 3: Fatorial
// - **Descrição:** Crie um programa que calcule o fatorial de um número fornecido pelo usuário utilizando o loop `do-while`.

int numero = 5;
int sum = 1;
int i = 1;
do
{
    sum *= i;
    i++;
}
while (i <= numero);


// for (int i = 1; i <= numero; i++)
// {
//     //fatorial de 5 = 5 x 4 x 3 x 2 x 1 = 120; 
//     // i vai contar de 1 a 5;
//     sum *= i;
// }

Console.WriteLine($"Exercício 3: {sum}");
Console.WriteLine($"-----------------------");


// #### Exercício 4: Lista de Compras
// - **Descrição:** Use um loop `foreach` para iterar sobre uma lista de itens de compras e imprimir cada item. A lista deve ser preenchida pelo usuário.

// List<string> listaDeCompras = new List<string>();

// void adicionarItem() {
//     Console.WriteLine($"Digite para adicionar um novo item na sua lista de compras:");
//     listaDeCompras.Add(Console.ReadLine());
// }

// adicionarItem();

// Console.WriteLine($"Deseja adicionar um novo item?");

// while (Console.ReadLine() == "sim")
// {
//     adicionarItem();
//     Console.WriteLine($"Deseja adicionar um novo item?");
// }

// foreach (var item in listaDeCompras)
// {
//     Console.WriteLine($"Exercício 4: Lista de Compras: {item}");
// }

// #### Exercício 5: Contagem Regressiva
// - **Descrição:** Escreva um programa que realiza uma contagem regressiva de 10 até 1 e então imprime "Lançamento!". Use o loop `for`.


// for (int contagemRegressiva = 10; contagemRegressiva > 0; contagemRegressiva--)
// {
//     Console.WriteLine($"Exercício 5: {contagemRegressiva}");
// }
// Console.WriteLine($"Exercício 5: Lançamento!");

// #### Exercício 6: Adivinhe o Número
// - **Descrição:** Implemente um jogo simples usando um loop `while` onde o usuário deve adivinhar um número aleatório gerado pelo sistema entre 1 e 100. 
// Após cada tentativa, o programa deve dizer se o número é maior ou menor que o número a ser adivinhado.

// Random random = new Random();
// int numeroDoSistema = random.Next(1, 5); 
// int numeroDoUsuario;

// Console.WriteLine($"Exercício 6: Adivinhe o numero:");
// numeroDoUsuario = int.Parse(Console.ReadLine());


// tryparse retorna um bool, se conseguiu parsear ou nao, segundo argumento retorna uma nova variable:
// var novoNumero = "10.5";
// var teste = int.TryParse(novoNumero, out int resultado2);
// var teste2 = double.TryParse(novoNumero, out double resultado3);
// Console.WriteLine($"teste: {teste}");
// Console.WriteLine(resultado2);
// Console.WriteLine(resultado3);




// while (numeroDoSistema != numeroDoUsuario)
// {
//     Console.WriteLine($"Exercício 6: voce errou, tenta de novo:");
//     if(numeroDoUsuario != null) {
//         if(numeroDoSistema > numeroDoUsuario){
//             Console.WriteLine($"numero do sistema eh maior que o numero informado.");
//         } else if (numeroDoSistema < numeroDoUsuario){
//             Console.WriteLine($"numero do sistema eh menor que o numero informado.");
//         }

//     }
//     numeroDoUsuario = Int32.Parse(Console.ReadLine());
// }
// Console.WriteLine($"Exercício 6: voce acertou o numero");


// #### Exercício 7: Tabuada
// - **Descrição:** Utilize um loop `for` aninhado para imprimir a tabuada de números de 1 a 10.


// for (int n2 = 1; n2 <= 10; n2++)
// {
//     for (int n3 = 1; n3 <= 10; n3++)
//     {
//         int resultado = n2 * n3;
//         Console.WriteLine($"Exercício 7: {n2} x {n3} = {resultado}");
//     }
// }

// #### Exercício 8: Verificador de Primos
// - **Descrição:** Desenvolva um programa que verifica se um número fornecido pelo usuário é primo, 
// utilizando um loop `for` para verificar divisões sucessivas.

Console.WriteLine($"Exercício 8: escolha um numero:");
int n6 = int.Parse(Console.ReadLine());
var res = VerificaNumeroPrimo(n6) ? "é" : "não é";

Console.WriteLine($"Exercício 8: seu numero {n6} {res} um numero primo.");

bool VerificaNumeroPrimo(int numero)
{
    bool ePrimo = true;
    // loop começa em 2 porque todos os numeros sao divisiveis por um
    // loop acontece ate chegar na raiz quadrada do numero informado
    for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
    {
        if (numero % divisor == 0)
        // numero primo nao pode restar zero na divisao, pq soh divide por um e ele mesmo
        {
            ePrimo = false;
            break;
        }
    }
    return ePrimo;
}


// #### Exercício 9: Inversão de String
// - **Descrição:** Escreva um programa que inverte uma string fornecida pelo usuário usando um loop `for`.

var minhaPalavra = "almoco";
char[] caracteres = minhaPalavra.ToCharArray(); // diferenca de char array para string array? => char guarda soh um caracter;

char[] palavraInvertida = new char[minhaPalavra.Length];
var indexDaNovaPalavra = 0;


// string novaString = new string(caracteres, 1, caracteres.Length - 1);
//     Console.WriteLine(caracteres[2]);
//     Console.WriteLine(novaString);

for (int stringLenght = minhaPalavra.Length; stringLenght > 0; stringLenght--)
{
    // seleciona ultimo caracter pelo index
    int index = stringLenght - 1;

    palavraInvertida[indexDaNovaPalavra] = caracteres[index];
    indexDaNovaPalavra++;
}

string resultado5 = new string(palavraInvertida);
Console.WriteLine($"Exercício 9: {resultado5}");

// #### Exercício 10: Soma de uma Sequência
// - **Descrição:** Solicite ao usuário uma sequência de números, termine a entrada com zero, 
// e use um loop `while` para calcular a soma dos números fornecidos.

Console.WriteLine("Exercício 10: Informe 3 numeros (separados com virgula):");
int soma = 0;

string imput = Console.ReadLine();
string[] numbersAsString = imput.Split(',');
int[] n5 = numbersAsString.Select(int.Parse).ToArray();
int y = 0;

while (y < n5.Length)
{
    soma += n5[y];
    y++;
}
Console.WriteLine($"Exercício 10: resultado da soma = {soma}");
