
/*int a = 3;
int b = 5;
int c = 6;
int d = 7;*/


/*int[] T = new int[4];
T[0] = 3;
T[1] = 5;
T[2] = 6;
T[3] = 7;*/

/*int[] L = new int[] { 3, 5, 6, 7, 11 };

for (int i = 0; i < L.Length; i++)
{
    Console.WriteLine(L[i]);
}*/



/*int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}*/

// Stwórz tablicę n liczb wpisanych przez usera. Wypisz ostatnią z nich.
/*int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(W[n-1]);*/

// Stwórz tablicę n liczb wpisanych przez usera. Wypisz sumę tych liczb.
/*int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
int suma = 0;
for (int i = 0; i < W.Length; i++)
{
    suma += W[i];
}
Console.WriteLine(suma);*/

// Stwórz tablicę n liczb wpisanych przez usera. Wypisz największą liczbe.
/*
int maksik = int.MinValue;
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > maksik)
    {
        maksik = W[i];
    }
}
Console.WriteLine(maksik);*/


// Stwórz tablicę n liczb wpisanych przez usera. Wypisz ilość największej liczby.
// Console.WriteLine(int.MinValue) - minimalny 

int maksik = int.MinValue;
int ilosc = 1;
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > maksik)
    {
        maksik = W[i];
        ilosc = 1;
    }
    else if (W[i] == maksik)
    {
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);

// Stwórz tablicę n liczb wpisanych przez usera.
// Wypisz sumę liczb o parzystych indeksach.

