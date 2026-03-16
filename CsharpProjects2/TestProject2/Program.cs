
// O código a seguir cria cinco IDs de Pedido aleatórios
// para testar o processo de detecção de fraudes. Os IDs de Pedido
// consistem em uma letra de A a E e um número de três
// dígitos. Ex.: A123.

Random random = new Random();
string[] orderIDs = new string[5];
// Percorra cada ID de pedido em branco.
for (int i = 0; i < orderIDs.Length; i++)
{
    // Obtenha um valor aleatório que corresponda às letras ASCII de A a E.
    int prefixValue = random.Next(65, 70);
    // Converta o valor aleatório em um caractere e, em seguida, em uma string.
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Gere um número aleatório e preencha com zeros.
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine o prefixo e o sufixo e, em seguida, atribua-os ao ID do pedido atual.
    orderIDs[i] = prefix + suffix;
}
// Imprima cada ID de pedido.
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");