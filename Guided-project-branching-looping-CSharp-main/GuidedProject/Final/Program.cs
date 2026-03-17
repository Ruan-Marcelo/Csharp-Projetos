using System;

// o array ourAnimals irá armazenar:
string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string apelidoAnimal = "";

// variáveis de apoio para entrada de dados
int maxPets = 8;
string? resultadoLeitura;
string selecaoMenu = "";

// array que armazena os dados em tempo de execução
string[,] nossosAnimais = new string[maxPets, 6];

// criando alguns dados iniciais
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "cachorro";
            idAnimal = "d1";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "fêmea de porte médio, cor creme, golden retriever com cerca de 30kg. treinada.";
            descricaoPersonalidadeAnimal = "adora carinho na barriga e correr atrás do próprio rabo. muito carinhosa.";
            apelidoAnimal = "lola";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "d2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "macho grande marrom-avermelhado, golden retriever com cerca de 38kg. treinado.";
            descricaoPersonalidadeAnimal = "adora carinho nas orelhas e abraços. muito amigável.";
            apelidoAnimal = "loki";
            break;

        case 2:
            especieAnimal = "gato";
            idAnimal = "c3";
            idadeAnimal = "1";
            descricaoFisicaAnimal = "fêmea pequena branca com cerca de 4kg. usa caixa de areia.";
            descricaoPersonalidadeAnimal = "amigável";
            apelidoAnimal = "puss";
            break;

        case 3:
            especieAnimal = "gato";
            idAnimal = "c4";
            idadeAnimal = "?";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            break;

        default:
            especieAnimal = "";
            idAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            break;
    }

    nossosAnimais[i, 0] = "ID #: " + idAnimal;
    nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
    nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
    nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
    nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
    nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
}

do
{
    Console.Clear();

    Console.WriteLine("Bem-vindo ao sistema Contoso PetFriends. Menu principal:");
    Console.WriteLine(" 1. Listar todos os animais");
    Console.WriteLine(" 2. Adicionar um novo animal");
    Console.WriteLine(" 3. Verificar idade e descrição física");
    Console.WriteLine(" 4. Verificar apelido e personalidade");
    Console.WriteLine(" 5. Editar idade do animal");
    Console.WriteLine(" 6. Editar personalidade do animal");
    Console.WriteLine(" 7. Mostrar gatos com característica específica");
    Console.WriteLine(" 8. Mostrar cachorros com característica específica");
    Console.WriteLine();
    Console.WriteLine("Digite a opção (ou 'exit' para sair)");

    resultadoLeitura = Console.ReadLine();

    if (resultadoLeitura != null)
    {
        selecaoMenu = resultadoLeitura.ToLower();
    }

    switch (selecaoMenu)
    {
        case "1":
            for (int i = 0; i < maxPets; i++)
            {
                if (nossosAnimais[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(nossosAnimais[i, j]);
                    }
                }
            }
            Console.WriteLine("\nPressione Enter para continuar");
            Console.ReadLine();
            break;

        case "2":
            string outroPet = "s";
            int contadorPets = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (nossosAnimais[i, 0] != "ID #: ")
                {
                    contadorPets++;
                }
            }

            if (contadorPets < maxPets)
            {
                Console.WriteLine($"Temos {contadorPets} pets. Podemos cadastrar mais {maxPets - contadorPets}.");
            }

            while (outroPet == "s" && contadorPets < maxPets)
            {
                bool entradaValida = false;

                do
                {
                    Console.WriteLine("Digite 'cachorro' ou 'gato':");
                    resultadoLeitura = Console.ReadLine();

                    if (resultadoLeitura != null)
                    {
                        especieAnimal = resultadoLeitura.ToLower();
                        entradaValida = (especieAnimal == "cachorro" || especieAnimal == "gato");
                    }
                } while (!entradaValida);

                idAnimal = especieAnimal.Substring(0, 1) + (contadorPets + 1);

                do
                {
                    Console.WriteLine("Digite a idade ou ?:");
                    resultadoLeitura = Console.ReadLine();

                    if (resultadoLeitura != null)
                    {
                        idadeAnimal = resultadoLeitura;
                        if (idadeAnimal == "?" || int.TryParse(idadeAnimal, out _))
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            entradaValida = false;
                        }
                    }
                } while (!entradaValida);

                Console.WriteLine("Descrição física:");
                descricaoFisicaAnimal = Console.ReadLine() ?? "tbd";

                Console.WriteLine("Personalidade:");
                descricaoPersonalidadeAnimal = Console.ReadLine() ?? "tbd";

                Console.WriteLine("Apelido:");
                apelidoAnimal = Console.ReadLine() ?? "tbd";

                nossosAnimais[contadorPets, 0] = "ID #: " + idAnimal;
                nossosAnimais[contadorPets, 1] = "Espécie: " + especieAnimal;
                nossosAnimais[contadorPets, 2] = "Idade: " + idadeAnimal;
                nossosAnimais[contadorPets, 3] = "Apelido: " + apelidoAnimal;
                nossosAnimais[contadorPets, 4] = "Descrição física: " + descricaoFisicaAnimal;
                nossosAnimais[contadorPets, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;

                contadorPets++;

                if (contadorPets < maxPets)
                {
                    Console.WriteLine("Adicionar outro? (s/n)");
                    outroPet = Console.ReadLine()?.ToLower() ?? "n";
                }
            }

            break;

        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
            Console.WriteLine("EM DESENVOLVIMENTO...");
            Console.WriteLine("Pressione Enter para continuar.");
            Console.ReadLine();
            break;
    }

} while (selecaoMenu != "exit");