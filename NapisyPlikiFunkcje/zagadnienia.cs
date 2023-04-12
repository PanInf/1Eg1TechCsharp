// Zagadnienia na sprawdzian

// 1. Funkcje

// 1.1 - Napisz funkcje która zwraca sume cyfr podaniej liczby

/*int n = int.Parse(Console.ReadLine());

int sumaCyfr(int n)
{
	int suma = 0;
	while (n > 0)
	{
		suma += n % 10;
		n = n / 10;
	}
	return suma;
}
Console.WriteLine(sumaCyfr(n));*/

// 1.2 - Napisz funkcje, która zwraca odwrócony do wprowadzonego napis

/*string napis = Console.ReadLine();
char[] T = napis.ToCharArray();
Array.Reverse(T);
Console.WriteLine(new String(T));*/


// 1.3 - Napisz funkcje, która wypisuje łańcuch połówek wpisanej liczby, aż do 1. Np po wpisaniu 30 otrzymujemy 30-15-7-3-1. Rozumiecie? :)

/*int n = int.Parse(Console.ReadLine());
string wynik = "";
wynik += n;
while (n>1)
{
	n = n / 2;
	wynik += "-" + n;
}
Console.WriteLine(wynik);*/

// 2. Rekurencja

// 2.1 - Napisz rekurencyjnie n liczb: 3,5,7,9,11...

/*int a = int.Parse(Console.ReadLine());

int rekua(int n)
{
	if (n==1)
	{
		return 3;
	}
	return rekua(n - 1) + 2;
}

for (int i = 1; i <= a; i++)
{
	Console.WriteLine(rekua(i));
}*/

// 2.2 - Napisz rekurencyjnie n liczb: 6, 12, 24, 48, 96...

/*int a = int.Parse(Console.ReadLine());

int rekub(int n)
{
    if (n == 1)
    {
        return 6;
    }
    return rekub(n - 1) * 2;
}

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(rekub(i));
}*/

// 2.3 - Napisz rekurencyjnie n liczb: 1,1,3,5,11,21...

/*int c = int.Parse(Console.ReadLine());

int rekuc(int n)
{
	if (n < 3) return 1;
	return 2 * rekuc(n - 2) + rekuc(n - 1);
}

for (int i = 1; i <= c; i++)
{
	Console.WriteLine(rekuc(i));
}*/

// 2.4 - Napisz rekurencyjnie n liczb: 1,2,-1,3,-4,7,-11,18...

/*int d = int.Parse(Console.ReadLine());

int rekud(int n)
{
	if (n == 1) return 1;
	if (n == 2) return 2;
	return rekud(n-2) - rekud(n-1);
}

for (int i = 1; i <= d; i++)
{
	Console.WriteLine(rekud(i));
}*/

// 2.5 - Napisz rekurencyjnie n liczb: 1,2,3,0,6,3,-3,21...

/*int e = int.Parse(Console.ReadLine());

int rekue(int n)
{
	if (n == 1) return 1;
    if (n == 2) return 2;
    if (n == 3) return 3;
	return 3 * rekue(n-3) - rekue(n-1);
}

for (int i = 1; i <= e; i++)
{
	Console.WriteLine(rekue(i));
}*/


// 3. Plik

// 3.1 Stwórz plik z dzisiejszą datą

/*StreamWriter sw1 = new StreamWriter(@"C:\poligon\plik1.txt");
sw1.WriteLine(DateTime.Now);
sw1.Flush();
sw1.Close();*/

// 3.2 Zapisz do pliku 10 losowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb

/*StreamWriter sw2 = new StreamWriter(@"C:\poligon\plik2.txt");

Random random = new Random();
for (int i = 0; i < 10; i++)
{
	sw2.WriteLine(random.Next(10, 99));
}

sw2.Close();

string[] lines = System.IO.File.ReadAllLines(@"C:\poligon\plik2.txt");
int[] T = new int[10];
for (int i = 0; i < 10; i++)
{
	T[i] = int.Parse(lines[i]);
}
Console.WriteLine(T.Max());*/

// 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.

/*StreamWriter sw2 = new StreamWriter(@"C:\poligon\plik3.txt");

Random random = new Random();
for (int i = 0; i < 100; i++)
{
    sw2.WriteLine(random.Next(100, 999));
}

sw2.Close();

string[] lines = System.IO.File.ReadAllLines(@"C:\poligon\plik3.txt");
int[] T = new int[100];
for (int i = 0; i < 100; i++)
{
    T[i] = int.Parse(lines[i]);
	if (T[i] / 100 == T[i] % 10)
	{
		Console.Write(T[i] + " ");
	}
}*/
