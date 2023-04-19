// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


//Algoritmo
//Criar variaveis para Nome(string), preco(float) e promocao(bool)
//Criar menu com cadastro de produto, lista de produtos.
//criar funcoes

Console.WriteLine($"Cadastro de produtos");

// static void menuOpcoes();
string opcao;

string[] nomeProduto = new string[10];
float[] preco = new float[10];
bool promocao = false;
string respostaPromo;
string respostaCad;

do
{

    Console.WriteLine(@$"
----------------------------
            Menu
----------------------------
[1] Cadastrar
[2] Listar
[0] Sair
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            do
            {
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Qual o produto? ");
                    nomeProduto[i] = Console.ReadLine();

                    Console.WriteLine($"Qual o preco? ");
                    preco[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Esta na promocao? s/n");
                    respostaPromo = Console.ReadLine().ToLower();

                    if (respostaPromo == "s")
                    {
                        promocao = true;
                    }
                    else
                    {
                        promocao = false;
                    }
                }
                Console.WriteLine($"Deseja cadastrar mais produtos? s/n");
                respostaCad = Console.ReadLine().ToLower();
            } while (respostaCad == "s");
            break;

        case "2":

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(@$"
            *****Produtos*****
            Nome: {nomeProduto[i]}
            Preco: {preco[i]}
            Esta na promocao? {promocao}
            ");

            }

            break;

        default:
            Console.WriteLine($"Opcao invalida!");
            break;
    }

} while (opcao != "0");