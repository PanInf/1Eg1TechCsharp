// 1. Wczytaj do tablicy listy dzielniki podanej przez usera
// liczby n. W osobnej pętli je wyświtl.

/*int n = int.Parse(Console.ReadLine());
ArrayList A = new ArrayList();

for (int i = 1; i < n+1; i++)
{
	if (n % i == 0)
	{
		A.Add(i);
	}
}

foreach (var item in A)
	Console.Write(item + " ");*/


// 2. Wczytaj do tablicy 20 losowych liczb 3-cyfrowych
// złożonych niepodzielnych przez 2

/*bool czyPierwsza(int n)
{
	for (int i = 2; i < n; i++)
	{
		if (n % i == 0)
		{
			return false;
		}
	}
	return true;
}
Random	r = new Random();
int[] T = new int[20];
int liczba, ilosc = 0;
while (ilosc < 20)
{
	liczba = r.Next(100, 1000);
	if (liczba % 2 == 0 && !czyPierwsza(liczba))
	{
		T[ilosc] = liczba;
		ilosc++;
	}
}*/

//3. Wygeneruj tablicę 40 losowych 2-cyfrowych. Znajdz sumę tych co wystepują podwójnie.

/*Random r = new Random();
int[] T = new int[40];
int[] L = new int[100];
for (int i = 0; i < 40; i++)
{
	T[i] = r.Next(10, 100);
	L[T[i]]++;
}
int suma = 0;
for (int j = 0; j < 100; j++)
{
	if (L[j] == 2)
	{
		suma += 2 * j;
	}
}

foreach (var item in T)
{
	Console.Write(item + " ");
}

foreach (var item in L)
{
    Console.Write(item + " ");
}
Console.WriteLine(suma);*/

//4. Wygen macierz 11x11 i znajdz sume
//cyfr znajdujacych sie na diagonalach (dlugich przekątnych)

Random r = new Random();
int n = 11;
int[,] M = new int[n,n];

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		M[i, j] = r.Next(1, 10);
	}
}

int suma = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
		if (i - j == 0 || i + j == n - 1)
		{
			suma += M[i, j];
		}
    }
}
Console.WriteLine(suma);
