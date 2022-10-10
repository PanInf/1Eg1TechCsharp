/*

// Zad 1
int n = int.Parse(Console.ReadLine());
if (n % 3 == 0)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

*/



// Zad 3
/*
int wiek = int.Parse(Console.ReadLine());

Console.WriteLine(wiek>=18 ? "TAK" : "NIE");

if (wiek>=18)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}*/

// Zad 4
/*
const int LIMIT = 20;
int waga = int.Parse(Console.ReadLine());
Console.WriteLine(
    waga <= LIMIT ? "TAK, można wjechać" : "Nie, lepiej nie jedź"
    );
*/

// Zad 5
/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if ((a < c && b > c) || (b < c && a > c))
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

Console.WriteLine((a < c && b > c) || (b < c && a > c) ? "TAK" : "NIE");
*/

// Zad 6
/*
int a = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

if ((Math.Pow(a, p) - a) % p == 0)
{
    Console.WriteLine("TAK, spełnia MTF");
}
else
{
    Console.WriteLine("NIE, nie spełnia MTF");
}
*/

// Zad 7
/*
int p = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int s = int.Parse(Console.ReadLine());

if (p + 3*s >= k)
{
    Console.WriteLine("TAK, płaz przeskoczy");
}
else
{
    Console.WriteLine("NIE, nie da rady");
}
*/
