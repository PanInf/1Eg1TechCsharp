using System;
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

int j, tempik;
for (int i = 1; i < n; i++)
{
    tempik = T[i];
    j = i - 1;
    while (j >= 0 && tempik < T[j])
    {
        T[j+1] = T[j];
        j--;
    }
    T[j+1] = tempik;
}

// Sortowania w czasie liniowym

// 4. Przez zliczanie

// 5. Kubełkowe

// Dziel i zwyciężaj 

// 6. Przez scalanie

// 7. Quicksort Hoare

// 8. Quicksort Lomuto

// Wyświetlenie posortowanej tablicy

Console.WriteLine("\n");
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
