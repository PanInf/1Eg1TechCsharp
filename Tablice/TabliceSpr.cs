// 1. Wygeneruj tablicę z 15 losowymi liczbami dwucyfrowymi nieparzystymi

/*Random r = new Random();

int[] T = new int[15];

for (int i = 0; i < 15; i++)
{
    T[i] = r.Next(5,50) * 2 + 1;
}

foreach (var item in T)
{
    Console.Write(item + " ");
}
Console.WriteLine();*/

// 2. Wygeneruj tablicę 20 dowolnych liczb dwucyfrowych i potem zaokrąglij każdą w górę do pełnej 10-tki

/*Random r = new Random();

int[] T = new int[20];

for (int i = 0; i < 20; i++)
{
    T[i] = r.Next(10, 100);
    Console.Write(T[i] + " ");
    if (T[i] % 10 > 0)
    {
        T[i] = T[i] - (T[i] % 10) + 10;
    }
    Console.WriteLine(T[i]);
}

for (int i = 0; i < 20; i++)
{
    T[i] = r.Next(10, 100);
    Console.Write(T[i] + " ");
    T[i] = (T[i] / 10) * 10;
    Console.WriteLine(T[i]);
}*/

// 3. Wygeneruj listę 12 losowych liczb dwucyfrowych podzielnych przez 7

/*Random r = new Random();
int[] T = new int[12];

for (int i = 0; i < 12; i++)
{
    T[i] = r.Next(2, 15) * 7;
    Console.WriteLine(T[i]);
}*/

// 4. Wygeneruj tablicę 10 losowych liczb pierwszych
// W1 - ArrayList

// W2 - Tablice

Random r = new Random();
int[] T = new int[10];
int j = 0;

while (true)
{
    bool flaga = true;
    int x = r.Next(10, 100);
    for (int i = 2; i < x / 2 + 1; i++)
    {
        if (x % i == 0)
        {
            flaga = false;
            break;
        }
    }
    if (flaga)
    {
        T[j] = x;
        j++;
    }
    if (j==10)
    {
        break;
    }
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}
Console.WriteLine();

// 5. Wygeneruj tablicę 40 losowych liczb trzycyfrwych i wypisz sumę na pozycjach nieparzystych 1,3,5 itd....

// 6. Wygeneruj losową tablicę 20 elementową składającą się z cyfr 1, 2 i 3.
// Znajdź najdłuższy podciąg identycznych cyfr. Jeśli jest więcej tak samo długich to wypisz ostatni z nich.

// 7. Dla chętnych - Algorytm Kadane'a

// 8. Listy 2-wymiarowe. Wygeneruj listę 10x10 losowych cyfr. Znajdz w ilu miejscach wystepują tacy sami sąsiedzi (lewo-prawo i góra-dół).
