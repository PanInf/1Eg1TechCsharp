using System;
using System.Globalization;
using System.Transactions;
// Sortowania przez porównanie

// Stworzenie tablicy 10 losowych liczb <1;20>

Random r = new Random();
int n = 10;
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");

// 1. Bąbelkowe (bubble sort)

// od prawej rosnąco

/*int tempik;
for (int i = n - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (T[j] > T[j+1])
        {
            tempik = T[j];
            T[j] = T[j + 1];
            T[j + 1] = tempik;
        }
    }
}*/

// 2. Przez wybór (selection sort)

// wybieramy najmniejszy i wstawiamy go na początek

/*int k;
int tempik;
for (int i = 0; i < n; i++)
{
    k = i;
    for (int j = i + 1; j < n; j++)
        if (T[j] < T[k]) k = j;
    tempik = T[i];
    T[i] = T[k];
    T[k] = tempik;
}*/

// wybieramy najmniejszy i wstawiamy go na koniec

/*int k;
int tempik;
for (int i = n-1; i > 0; i--)
{
    k = i;
    for (int j = 0; j < i; j++)
        if (T[j] < T[k]) k = j;
    tempik = T[i];
    T[i] = T[k];
    T[k] = tempik;
}*/

// 3. Przez wstawianie (insertion sort)

/*int j, tempik;
for (int i = 1; i < n; i++)
{
    tempik = T[i];
    j = i - 1;
    while (j >= 0 && tempik < T[j])
    {
        T[j + 1] = T[j];
        j--;
    }
    T[j + 1] = tempik;
}*/

// Sortowania w czasie liniowym - O(n)

// 4. Przez zliczanie (counting sort)

/*int[] L = new int[20];

for (int i = 0; i < n; i++)
{
    L[T[i]]++;
}

for (int i = 0; i < L.Length; i++)
{
    Console.Write(L[i] + " ");
}

int j = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        for (int k = 0; k < L[i]; k++)
        {
            T[j] = i;
            j++;
        }   
    }
}

Console.WriteLine("\n");*/

// 5. Grzebieniowe

int tempik, gap = n;
bool swaped = true;

while (gap > 1 || swaped == true)
{
    gap = gap * 10 / 13;
    if (gap == 0)
    {
        gap = 1;
    }
    swaped = false;
    for (int i = 0; i < n - gap; i++)
    {
        if (T[i] > T[i+gap])
        {
            tempik = T[i];
            T[i] = T[i + gap];
            T[i + gap] = tempik;
            swaped = true;
        }
    }
}

// Dziel i zwyciężaj 

// 6. Przez scalanie


/*void scalaj(int lewy, int prawy)  //0-3
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++) pom[a] = T[a];
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy;  // indeks tabeli
    i_lewy = lewy;
    i_prawy = srodek + 1;

    while (i_lewy <= srodek && i_prawy <= prawy)
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else
        {
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
        while (i_prawy <= prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    else
        while (i_lewy <= srodek)
        {
            T[i] = pom[i_lewy];
            i_lewy++;
            i++;
        }
}

void sortuj(int lewy, int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < srodek)
    {
        sortuj(lewy, srodek);
    }
    if (srodek + 1 < prawy)
    {
        sortuj(srodek + 1, prawy);
    }
    scalaj(lewy, prawy);
}

sortuj(0, n - 1);*/

// 7. Quicksort Hoare

/*void quicksortHoare(int lewy, int prawy)
{
    int i = lewy;
    int j = prawy;
    int tempik;
    int pivot = T[(lewy + prawy) / 2];

    while (i <= j)
    {
        while (T[i] < pivot) i++;
        while (T[j] > pivot) j--;
        if (i <= j)
        {
            tempik = T[i];
            T[i] = T[j];
            T[j] = tempik;
            i++;
            j--;
        }
    }
    if (lewy < j) quicksortHoare(lewy, j);
    if (prawy > i) quicksortHoare(i, prawy);
}

quicksortHoare(0, n - 1);
*/
// 8. Quicksort Lomuto

/*void quicksortLomuto(int lewy, int prawy)
{
    int pivot = T[prawy];
    int i = lewy;
    int tempik;
    for (int k = lewy; k < prawy; k++)
    {
        if (T[k] <= pivot)
        {
            tempik = T[i];
            T[i] = T[k];
            T[k] = tempik;
            i++;
        }
    }
    tempik = T[i];
    T[i] = T[prawy];
    T[prawy] = tempik;

    if (lewy < i - 1) quicksortLomuto(lewy, i - 1);
    if (prawy > i + 1) quicksortLomuto(i + 1, prawy);
}

quicksortLomuto(0, n - 1);
*/
// Wyświetlenie posortowanej tablicy

for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
