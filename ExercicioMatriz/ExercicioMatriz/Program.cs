//Exercicio 1
//============================================

int j, k;
int[,] matriz = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        Console.Write($"{matriz[ j , k ]}");
    }
    Console.WriteLine();
}



//Exercicio 2
//============================================

int r, p;
int[,] matriz2 = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };
int total = 0;
for (r = 0; r < 3; r++)
{
    for (p = 0; p < 3; p++)
    {
        total += matriz2[r, p];
    }
    Console.WriteLine();
}
Console.WriteLine($"Total: {total}");


//Exercicio 3
//============================================

int r, p;
int[,] matriz2 = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };
int total = 0;
for (r = 0; r < 3; r++)
{
    for (p = 0; p < 3; p++)
    {
        total += matriz2[r, p];
    }
    Console.WriteLine();
}
Console.WriteLine($"A média de todos os número é de: {total / 9}");


//Exercicio 4
//============================================

int g, e;
int[,] matriz3 = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };

int valorMaior = 0;

for (g = 0; g < 3; g++)
{
    for (e = 0; e < 3; e++)
    {
        if(matriz3[g, e] > valorMaior)
        {
            valorMaior = matriz3[g, e];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"O maior valor da matriz é {valorMaior}");



//Exercicio 5
//============================================

int c, v;
int[,] matriz3 = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };

int valorMenor;

for (c = 0; c < 3; c++)
{
    for (v = 0; v < 3; v++)
    {
        if (matriz3[c, v] < valorMenor)
        {
            valorMenor = matriz3[c, v];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"O menor valor da matriz é {valorMenor}");


//Exercicio 6
//============================================

int j, k;
bool temnaMatriz = false;
int valoraserEncontrado = 11;
    ;
int[,] matriz = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        if (matriz[j, k] == valoraserEncontrado)
        {
            temnaMatriz = true;            
        }
    }
    Console.WriteLine();
}

if (temnaMatriz == true)
{
    Console.WriteLine("O valor descrito está dentro da matriz");
}
else
{
    Console.WriteLine("O valor descrito não se encontra na matriz");
}


//Exercicio 7
//============================================

int j, k;
int[,] matriz7 = { { 2 ,1 ,1 },
                  { 5 ,9 ,-2 },
                  { -1,5 , 10 }
                };

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        Console.Write($"{matriz7[j, k]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("-----");
Console.WriteLine();

matriz7[1, 2] = 0;
matriz7[2, 0] = 0;
for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        Console.Write($"{matriz7[j, k]}");
    }
    Console.WriteLine();
}

