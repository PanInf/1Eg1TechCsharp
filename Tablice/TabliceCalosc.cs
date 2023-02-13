/*// Tablice 1D

// deklaracja
int[] T = new int[3];
// definicja
T[0] = 3;
T[1] = 5;
T[2] = 8;

// można połączyć deklaracje i definicję
int[] S = new int[] { 5, 7, 8, 9, 12 };

// przejście po tablicy - 2 podstawowe warianty przejść
for (int i = 0; i < S.Length; i++)
{
    Console.Write(S[i] + " ");
}
Console.WriteLine("\n");

foreach (var item in S)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

// wypełanie tablicy liczbami losowymi
int n = 100;
Random r = new Random();
int[] L = new int[n];
for (int i = 0; i < L.Length; i++)
{
    L[i] = r.Next(1,100);
    Console.Write(L[i] + " ");
}
Console.WriteLine("\n");*/

/*// Tablice 2D

// deklaracja
int[,] M = new int[3,2];    // M[wiersz,kolumna]
// definicja
M[0, 0] = 3;
M[0, 1] = 4;
M[1, 0] = 8;
M[1, 1] = 9;
M[2, 0] = 17;
M[2, 1] = 18;

int[,] N = new int[,] { { 2, 3, 4, 5 }, { 7, 8, 9, 10 }, { 16, 17, 18, 19} };
//Console.WriteLine(N[1,3]);
for (int i = 0; i < N.Length; i++)
{
    Console.Write(N[i / N.GetLength(1),i % N.GetLength(1)] + " ");
}
Console.WriteLine("\n");

for (int i = 0; i < N.GetLength(0); i++)
{
    for (int j = 0; j < N.GetLength(1); j++)
    {
        Console.Write(N[i,j] + "\t");
    }
    Console.WriteLine();
}

// Losowe generowanie macierzy
int n = 13;
int m = 7;
int[,] G = new int[n, m];
Random r = new Random();
for (int i = 0; i < G.GetLength(0); i++)
{
    for (int j = 0; j < G.GetLength(1); j++)
    {
        G[i, j] = r.Next(100, 1000);
        Console.Write(G[i, j] + "\t");
    }
    Console.WriteLine();
}*/

// List i ArrayList

using System.Collections;

ArrayList AL = new ArrayList();
AL.Add(5);
AL.Add(8);
AL.Add(12);
AL.Add(12);
// .... ile chce tych Add-ów

Console.WriteLine(AL.Count);
Console.WriteLine(AL[2]);
AL.Remove(5);
Console.WriteLine(AL.Count);
AL.RemoveAt(0);
Console.WriteLine(AL.Count);
